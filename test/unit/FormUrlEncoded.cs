// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using AutoRest.Core;
using AutoRest.Core.Utilities;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Xunit;
using Xunit.Abstractions;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.CSharp.Unit.Tests
{
    public class FormUrlEncoded : BugTest
    {
        public FormUrlEncoded(ITestOutputHelper output) : base(output)
        {
        }

        /// <summary>
        ///     Server code that returns a simple model.
        /// </summary>
        [Fact]
        public async Task CompileAndVerifyServerCode()
        {
            using (NewContext)
            {
                MemoryFileSystem fileSystem = CreateMockFilesystem();

                var settings = new Settings
                {
                    FileSystemInput = fileSystem,
                    OutputDirectory = "",
                    Namespace = "Test"
                    ,PayloadFlatteningThreshold=3
                };
                
                using (fileSystem = $"{GetType().Name}".GenerateCodeInto(fileSystem, settings))
                {
                    var result = await Compile(fileSystem);

                    // filter the warnings
                    var warnings = result.Messages.Where(
                        each => each.Severity == DiagnosticSeverity.Warning
                                && !SuppressWarnings.Contains(each.Id)).ToArray();

                    // use this to dump the files to disk for examination
                    // fileSystem.SaveFilesToTemp($"{GetType().Name}");

                    // filter the errors
                    var errors = result.Messages.Where(each => each.Severity == DiagnosticSeverity.Error).ToArray();

                    Write(warnings, fileSystem);
                    Write(errors, fileSystem);

                    // use this to write out all the messages, even hidden ones.
                    // Write(result.Messages, fileSystem);

                    // Don't proceed unless we have zero Warnings.
                    Assert.Empty(warnings);

                    // Don't proceed unless we have zero Errors.
                    Assert.Empty(errors);

                    // Load and reflect on the assembly
                    var asm = LoadAssembly(result.Output);
                    Assert.NotNull(asm);
                }
            }
        }
    }
}