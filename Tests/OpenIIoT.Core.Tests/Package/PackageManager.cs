﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄███████▄                                                                 ▄▄▄▄███▄▄▄▄
      █     ███    ███                                                               ▄██▀▀▀███▀▀▀██▄
      █     ███    ███   ▄█████   ▄██████    █  █▄     ▄█████     ▄████▄     ▄█████  ███   ███   ███   ▄█████  ██▄▄▄▄    ▄█████     ▄████▄     ▄█████    █████
      █     ███    ███   ██   ██ ██    ██   ██ ▄██▀    ██   ██   ██    ▀    ██   █   ███   ███   ███   ██   ██ ██▀▀▀█▄   ██   ██   ██    ▀    ██   █    ██  ██
      █   ▀█████████▀    ██   ██ ██    ▀    ██▐█▀      ██   ██  ▄██        ▄██▄▄     ███   ███   ███   ██   ██ ██   ██   ██   ██  ▄██        ▄██▄▄     ▄██▄▄█▀
      █     ███        ▀████████ ██    ▄  ▀▀████     ▀████████ ▀▀██ ███▄  ▀▀██▀▀     ███   ███   ███ ▀████████ ██   ██ ▀████████ ▀▀██ ███▄  ▀▀██▀▀    ▀███████
      █     ███          ██   ██ ██    ██   ██ ▀██▄    ██   ██   ██    ██   ██   █   ███   ███   ███   ██   ██ ██   ██   ██   ██   ██    ██   ██   █    ██  ██
      █    ▄████▀        ██   █▀ ██████▀    ▀█   ▀█▀   ██   █▀   ██████▀    ███████   ▀█   ███   █▀    ██   █▀  █   █    ██   █▀   ██████▀    ███████   ██  ██
      █
      █       ███
      █   ▀█████████▄
      █      ▀███▀▀██    ▄█████   ▄█████     ██      ▄█████
      █       ███   ▀   ██   █    ██  ▀  ▀███████▄   ██  ▀
      █       ███      ▄██▄▄      ██         ██  ▀   ██
      █       ███     ▀▀██▀▀    ▀███████     ██    ▀███████
      █       ███       ██   █     ▄  ██     ██       ▄  ██
      █      ▄████▀     ███████  ▄████▀     ▄██▀    ▄████▀
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Unit tests for the PackageManager class.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Moq;
using OpenIIoT.SDK;
using OpenIIoT.SDK.Common;
using OpenIIoT.SDK.Package;
using OpenIIoT.SDK.Platform;
using Utility.OperationResult;
using Xunit;

namespace OpenIIoT.Core.Tests.Package
{
    /// <summary>
    ///     Unit tests for the <see cref="Core.Package.PackageManager"/> class.
    /// </summary>
    public class PackageManager : IDisposable
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="PackageManager"/> class.
        /// </summary>
        public PackageManager()
        {
            Temp = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            Directory.CreateDirectory(Temp);

            Uri codeBaseUri = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            string codeBasePath = Uri.UnescapeDataString(codeBaseUri.AbsolutePath);
            string dirPath = Path.GetDirectoryName(codeBasePath);

            DataRoot = Path.Combine(dirPath, "Package", "Data");
            Data = Path.Combine(DataRoot, "Package");
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        ///     Gets or sets the package test data directory.
        /// </summary>
        private string Data { get; set; }

        /// <summary>
        ///     Gets or sets the root test data directory.
        /// </summary>
        private string DataRoot { get; set; }

        /// <summary>
        ///     Gets or sets the temporary data directory.
        /// </summary>
        private string Temp { get; set; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.CreatePackage(byte[])"/> method with a known good package payload.
        /// </summary>
        [Fact]
        public void CreatePackage()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();

            byte[] data = File.ReadAllBytes(Path.Combine(Data, "package.zip"));

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(successResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformMock.Setup(p => p.CopyFile(It.IsAny<string>(), It.IsAny<string>(), true))
                .Returns(successResult)
                    .Callback<string, string, bool>((s, d, o) => File.Copy(s, d, o));

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = test.CreatePackage(data);

            Assert.Equal(ResultCode.Success, package.ResultCode);
            Assert.True(File.Exists(Path.Combine(Temp, "OpenIIoT.Plugin.DefaultPlugin.1.0.0.zip")));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.CreatePackage(byte[])"/> method with a known good package payload.
        /// </summary>
        /// <returns>The Task with which the execution is carried out.</returns>
        [Fact]
        public async Task CreatePackageAsync()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();

            byte[] data = File.ReadAllBytes(Path.Combine(Data, "package.zip"));

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(successResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformMock.Setup(p => p.CopyFile(It.IsAny<string>(), It.IsAny<string>(), true))
                .Returns(successResult)
                    .Callback<string, string, bool>((s, d, o) => File.Copy(s, d, o));

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = await test.CreatePackageAsync(data);

            Assert.Equal(ResultCode.Success, package.ResultCode);
            Assert.True(File.Exists(Path.Combine(Temp, "OpenIIoT.Plugin.DefaultPlugin.1.0.0.zip")));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.CreatePackage(byte[])"/> method with a known bad package payload.
        /// </summary>
        [Fact]
        public void CreatePackageBadData()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();

            byte[] data = File.ReadAllBytes(Path.Combine(DataRoot, "notapackage.zip"));

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(successResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformMock.Setup(p => p.CopyFile(It.IsAny<string>(), It.IsAny<string>(), true))
                .Returns(successResult)
                    .Callback<string, string, bool>((s, d, o) => File.Copy(s, d, o));

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = test.CreatePackage(data);

            Assert.Equal(ResultCode.Failure, package.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.CreatePackage(byte[])"/> method with a mocked platform simulating
        ///     a failed file copy.
        /// </summary>
        [Fact]
        public void CreatePackageCopyFailed()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();
            IResult<string> failResult = new Result<string>(ResultCode.Failure);

            byte[] data = File.ReadAllBytes(Path.Combine(Data, "package.zip"));

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(successResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformMock.Setup(p => p.CopyFile(It.IsAny<string>(), It.IsAny<string>(), true))
                .Returns(failResult);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = test.CreatePackage(data);

            Assert.Equal(ResultCode.Failure, package.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.CreatePackage(byte[])"/> method with a mocked platform simulating
        ///     a failed file write.
        /// </summary>
        [Fact]
        public void CreatePackageWriteFailed()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> failResult = new Result<string>(ResultCode.Failure);

            byte[] data = new byte[] { };

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(failResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = test.CreatePackage(data);

            Assert.Equal(ResultCode.Failure, package.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.DeletePackage(string)"/> method.
        /// </summary>
        [Fact]
        public void DeletePackage()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();

            byte[] data = File.ReadAllBytes(Path.Combine(Data, "package.zip"));

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(successResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformMock.Setup(p => p.CopyFile(It.IsAny<string>(), It.IsAny<string>(), true))
                .Returns(successResult)
                    .Callback<string, string, bool>((s, d, o) => File.Copy(s, d, o));

            platformMock.Setup(p => p.DeleteFile(It.IsAny<string>()))
                .Returns(successResult)
                    .Callback<string>(s => File.Delete(s));

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = test.CreatePackage(data);

            Assert.Equal(ResultCode.Success, package.ResultCode);
            Assert.True(File.Exists(Path.Combine(Temp, "OpenIIoT.Plugin.DefaultPlugin.1.0.0.zip")));

            IResult deleteResult = test.DeletePackage(package.ReturnValue.FQN);

            Assert.Equal(ResultCode.Success, deleteResult.ResultCode);
            Assert.False(File.Exists(Path.Combine(Temp, "OpenIIoT.Plugin.DefaultPlugin.1.0.0.zip")));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.DeletePackageAsync(string)"/> method.
        /// </summary>
        [Fact]
        public async Task DeletePackageAsync()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();

            byte[] data = File.ReadAllBytes(Path.Combine(Data, "package.zip"));

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);
            platformMock.Setup(p => p.WriteFileBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Returns(successResult)
                    .Callback<string, byte[]>((f, b) => File.WriteAllBytes(f, b));

            platformMock.Setup(p => p.CopyFile(It.IsAny<string>(), It.IsAny<string>(), true))
                .Returns(successResult)
                    .Callback<string, string, bool>((s, d, o) => File.Copy(s, d, o));

            platformMock.Setup(p => p.DeleteFile(It.IsAny<string>()))
                .Returns(successResult)
                    .Callback<string>(s => File.Delete(s));

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IPackage> package = test.CreatePackage(data);

            Assert.Equal(ResultCode.Success, package.ResultCode);
            Assert.True(File.Exists(Path.Combine(Temp, "OpenIIoT.Plugin.DefaultPlugin.1.0.0.zip")));

            IResult deleteResult = await test.DeletePackageAsync(package.ReturnValue.FQN);

            Assert.Equal(ResultCode.Success, deleteResult.ResultCode);
            Assert.False(File.Exists(Path.Combine(Temp, "OpenIIoT.Plugin.DefaultPlugin.1.0.0.zip")));
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.DeletePackage(string)"/> method with a Package which does not exist.
        /// </summary>
        [Fact]
        public void DeletePackageNotFound()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<string> successResult = new Result<string>();

            dirMock.Setup(d => d.Packages).Returns(Temp);
            dirMock.Setup(d => d.Temp).Returns(Temp);

            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);

            IResult deleteResult = test.DeletePackage("test");

            Assert.Equal(ResultCode.Failure, deleteResult.ResultCode);
        }

        /// <summary>
        ///     Disposes of this instance.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.Instantiate(IApplicationManager, IPlatformManager)"/> method.
        /// </summary>
        [Fact]
        public void Instantiate()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();

            managerMock.Setup(a => a.State).Returns(State.Running);
            managerMock.Setup(a => a.IsInState(State.Starting, State.Running)).Returns(true);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.ScanPackages()"/> method with a bad directory.
        /// </summary>
        [Fact]
        public void ScanBadDirectory()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<IList<string>> dirResult = new Result<IList<string>>(ResultCode.Failure);

            dirMock.Setup(d => d.Packages).Returns(Data);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IList<IPackage>> list = test.ScanPackages();

            Assert.Equal(ResultCode.Failure, list.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.ScanPackages()"/> method with an empty directory.
        /// </summary>
        [Fact]
        public void ScanEmptyDirectory()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<IList<string>> dirResult = new Result<IList<string>>();
            dirResult.ReturnValue = new List<string>();

            dirMock.Setup(d => d.Packages).Returns(Data);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IList<IPackage>> list = test.ScanPackages();

            Assert.Equal(ResultCode.Success, list.ResultCode);

            Assert.NotNull(list.ReturnValue);
            Assert.Equal(0, list.ReturnValue.Count);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.ScanPackages()"/> method with a directory containing files but no Packages.
        /// </summary>
        [Fact]
        public void ScanNoPackages()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            File.WriteAllText(Path.Combine(Temp, "package.zip"), "hello world!");

            IResult<IList<string>> dirResult = new Result<IList<string>>();
            dirResult.ReturnValue = Directory.GetFiles(Temp).ToList();

            dirMock.Setup(d => d.Packages).Returns(Temp);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IList<IPackage>> list = test.ScanPackages();

            Assert.Equal(ResultCode.Warning, list.ResultCode);
            Assert.Equal(0, list.ReturnValue.Count);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.ScanPackages()"/> method with a directory containing Package files.
        /// </summary>
        [Fact]
        public void ScanPackages()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<IList<string>> dirResult = new Result<IList<string>>();
            dirResult.ReturnValue = Directory.GetFiles(Data).ToList();

            dirMock.Setup(d => d.Packages).Returns(Temp);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IList<IPackage>> list = test.ScanPackages();

            Assert.Equal(ResultCode.Success, list.ResultCode);
            Assert.Equal(3, list.ReturnValue.Count);

            // spot check a few Manifest fields to see if the manifest was fetched properly
            Assert.NotNull(list.ReturnValue[0].FQN);
            Assert.NotEqual(0, list.ReturnValue[0].FQN.Length);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.ScanPackagesAsync()"/> method with a directory containing Package files.
        /// </summary>
        /// <returns>The Task with which the execution is carried out.</returns>
        [Fact]
        public async Task ScanPackagesAsync()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<IList<string>> dirResult = new Result<IList<string>>();
            dirResult.ReturnValue = Directory.GetFiles(Data).ToList();

            dirMock.Setup(d => d.Packages).Returns(Temp);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);
            IResult<IList<IPackage>> list = await test.ScanPackagesAsync();

            Assert.Equal(ResultCode.Success, list.ResultCode);
            Assert.Equal(3, list.ReturnValue.Count);

            // spot check a few Manifest fields to see if the manifest was fetched properly
            Assert.NotNull(list.ReturnValue[0].FQN);
            Assert.NotEqual(0, list.ReturnValue[0].FQN.Length);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.Setup"/> method using reflection.
        /// </summary>
        [Fact]
        public void Setup()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();

            managerMock.Setup(a => a.State).Returns(State.Running);
            managerMock.Setup(a => a.IsInState(State.Starting, State.Running)).Returns(true);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);

            MethodInfo setup = typeof(Core.Package.PackageManager).GetMethod("Setup", BindingFlags.NonPublic | BindingFlags.Instance);
            setup.Invoke(test, new object[] { });
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.Startup()"/> method via <see cref="Core.Common.Manager.Start()"/> .
        /// </summary>
        [Fact]
        public void Start()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<IList<string>> dirResult = new Result<IList<string>>();
            dirResult.ReturnValue = Directory.GetFiles(Data).ToList();

            dirMock.Setup(d => d.Packages).Returns(Temp);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);
            platformManagerMock.Setup(p => p.State).Returns(State.Running);
            platformManagerMock.Setup(p => p.IsInState(State.Starting, State.Running)).Returns(true);

            managerMock.Setup(a => a.State).Returns(State.Running);
            managerMock.Setup(a => a.IsInState(State.Starting, State.Running)).Returns(true);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);

            IResult result = test.Start();

            Assert.NotEqual(ResultCode.Failure, result.ResultCode);
            Assert.Equal(State.Running, test.State);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.Shutdown(StopType)"/> method via
        ///     <see cref="Core.Common.Manager.Stop(StopType)"/> .
        /// </summary>
        [Fact]
        public void Stop()
        {
            Mock<IApplicationManager> managerMock = new Mock<IApplicationManager>();
            Mock<IPlatformManager> platformManagerMock = new Mock<IPlatformManager>();
            Mock<IDirectories> dirMock = new Mock<IDirectories>();
            Mock<IPlatform> platformMock = new Mock<IPlatform>();

            IResult<IList<string>> dirResult = new Result<IList<string>>();
            dirResult.ReturnValue = Directory.GetFiles(Data).ToList();

            dirMock.Setup(d => d.Packages).Returns(Temp);

            platformMock.Setup(p => p.ListFiles(It.IsAny<string>())).Returns(dirResult);
            platformMock.Setup(p => p.Directories).Returns(dirMock.Object);

            platformManagerMock.Setup(p => p.Platform).Returns(platformMock.Object);
            platformManagerMock.Setup(p => p.State).Returns(State.Running);
            platformManagerMock.Setup(p => p.IsInState(State.Starting, State.Running)).Returns(true);

            managerMock.Setup(a => a.State).Returns(State.Running);
            managerMock.Setup(a => a.IsInState(State.Starting, State.Running)).Returns(true);

            IPackageManager test = Core.Package.PackageManager.Instantiate(managerMock.Object, platformManagerMock.Object);

            IResult result = test.Start();

            Assert.NotEqual(ResultCode.Failure, result.ResultCode);
            Assert.Equal(State.Running, test.State);

            result = test.Stop();

            Assert.Equal(ResultCode.Success, result.ResultCode);
            Assert.Equal(State.Stopped, test.State);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Package.PackageManager.Terminate()"/> method.
        /// </summary>
        [Fact]
        public void Terminate()
        {
            Core.Package.PackageManager.Terminate();
        }

        #endregion Public Methods

        #region Protected Methods

        /// <summary>
        ///     Disposes of this instance.
        /// </summary>
        /// <param name="disposing">A value indicating whether this method has been called directly or indirectly from code.</param>
        protected virtual void Dispose(bool disposing)
        {
            Directory.Delete(Temp, true);

            Core.Package.PackageManager.Terminate();
        }

        #endregion Protected Methods
    }
}