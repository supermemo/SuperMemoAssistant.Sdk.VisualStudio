﻿#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   2020/03/31 00:04
// Modified On:  2020/03/31 03:16
// Modified By:  Alexis

#endregion




using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace SuperMemoAssistant.Sdk.VisualStudio
{
  /// <summary>This is the class that implements the package exposed by this assembly.</summary>
  /// <remarks>
  ///   <para>
  ///     The minimum requirement for a class to be considered a valid package for Visual Studio
  ///     is to implement the IVsPackage interface and register itself with the shell. This package
  ///     uses the helper classes defined inside the Managed Package Framework (MPF) to do it: it
  ///     derives from the Package class that provides the implementation of the IVsPackage
  ///     interface and uses the registration attributes defined in the framework to register itself
  ///     and its components with the shell. These attributes tell the pkgdef creation utility what
  ///     data to put into .pkgdef file.
  ///   </para>
  ///   <para>
  ///     To get loaded into VS, the package must be referred by &lt;Asset
  ///     Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
  ///   </para>
  /// </remarks>
  [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
  [Guid(PackageGuidString)]
  public sealed class SuperMemoAssistantPackage : AsyncPackage
  {
    #region Constants & Statics

    /// <summary>SuperMemoAssistant.Sdk.VisualStudioPackage GUID string.</summary>
    public const string PackageGuidString = "c09f5e26-a25e-4642-ab65-bfc4362794ac";

    #endregion




    #region Methods Impl

    /// <summary>
    ///   Initialization of the package; this method is called right after the package is
    ///   sited, so this is the place where you can put all the initialization code that rely on
    ///   services provided by VisualStudio.
    /// </summary>
    /// <param name="cancellationToken">
    ///   A cancellation token to monitor for initialization
    ///   cancellation, which can occur when VS is shutting down.
    /// </param>
    /// <param name="progress">A provider for progress updates.</param>
    /// <returns>
    ///   A task representing the async work of package initialization, or an already completed
    ///   task if there is none. Do not return null from this method.
    /// </returns>
    protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
      // When initialized asynchronously, the current thread may be a background thread at this point.
      // Do any initialization that requires the UI thread after switching to the UI thread.
      await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
    }

    #endregion
  }
}
