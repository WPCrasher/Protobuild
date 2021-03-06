﻿using System;

namespace Protobuild
{
    public interface IPackageManager
    {
        void ResolveAll(string workingDirectory, ModuleInfo module, string platform, bool? enableParallelisation, bool forceUpgrade, bool? safeResolve, bool? overrideSourcePreference);

        IPackageMetadata Lookup(string workingDirectory, ModuleInfo module, PackageRef reference, string platform, string templateName,
            bool? source,
            bool forceUpgrade, bool? safeResolve);

        void Resolve(string workingDirectoryAlt, IPackageMetadata metadata, PackageRef reference, string templateName, bool? source,
            bool forceUpgrade, bool? safeResolve);

        void Resolve(string workingDirectory, ModuleInfo module, PackageRef reference, string platform, string templateName, bool? source, bool forceUpgrade, bool? safeResolve);
    }
}

