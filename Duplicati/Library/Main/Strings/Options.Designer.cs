﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Main.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Options {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Options() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Main.Strings.Options", typeof(Options).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By supplying this option, Duplicati will transmit files, while building volumes. This can shorten the time it takes to perform a backup, but requires more diskspace..
        /// </summary>
        internal static string AsynchronousuploadLong {
            get {
                return ResourceManager.GetString("AsynchronousuploadLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transmit files on a seperate thread.
        /// </summary>
        internal static string AsynchronousuploadShort {
            get {
                return ResourceManager.GetString("AsynchronousuploadShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If a backup is interrupted there will likely be partial files present on the backend. Using this flag, Duplicati will automatically remove such files when encountered..
        /// </summary>
        internal static string AutocleanupLong {
            get {
                return ResourceManager.GetString("AutocleanupLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A flag indiciating that Duplicati should remove unused files.
        /// </summary>
        internal static string AutocleanupShort {
            get {
                return ResourceManager.GetString("AutocleanupShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Any string used to prefix the filenames generated by Duplicati..
        /// </summary>
        internal static string BackupprefixLong {
            get {
                return ResourceManager.GetString("BackupprefixLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup volume filename prefix.
        /// </summary>
        internal static string BackupprefixShort {
            get {
                return ResourceManager.GetString("BackupprefixShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operating system keeps track of the last time a file was written. Using this information, Duplicati can quickly determine if the file has been modified. If some application deliberately modifies this information, Duplicati won&apos;t work correctly unless this flag is set..
        /// </summary>
        internal static string DisablefiletimecheckLong {
            get {
                return ResourceManager.GetString("DisablefiletimecheckLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable checks based on file time.
        /// </summary>
        internal static string DisablefiletimecheckShort {
            get {
                return ResourceManager.GetString("DisablefiletimecheckShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling this option will disallow usage of the streaming interface, which means that transfer progress bars will not show, and bandwidth throttle settings will be ignored..
        /// </summary>
        internal static string DisableStreamingLong {
            get {
                return ResourceManager.GetString("DisableStreamingLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disables use of the streaming transfer method.
        /// </summary>
        internal static string DisableStreamingShort {
            get {
                return ResourceManager.GetString("DisableStreamingShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude files that match this filter. The filter is a &quot;file-globbing&quot; filter, much like commandline options. You can use &quot;*.txt&quot; to exclude all text files..
        /// </summary>
        internal static string ExcludeLong {
            get {
                return ResourceManager.GetString("ExcludeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude files that match this filter. The filter is a regular expression filter. You can use &quot;(.*)\.txt&quot; to exclude all text files..
        /// </summary>
        internal static string ExcluderegexpLong {
            get {
                return ResourceManager.GetString("ExcluderegexpLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude files regular expression.
        /// </summary>
        internal static string ExcluderegexpShort {
            get {
                return ResourceManager.GetString("ExcluderegexpShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude files.
        /// </summary>
        internal static string ExcludeShort {
            get {
                return ResourceManager.GetString("ExcludeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By default, duplicati will restore all files in the backup. Use this option to restore only a subset of the files.
        /// </summary>
        internal static string FiletorestoreLong {
            get {
                return ResourceManager.GetString("FiletorestoreLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A list of files to restore.
        /// </summary>
        internal static string FiletorestoreShort {
            get {
                return ResourceManager.GetString("FiletorestoreShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When deleting old files, Duplicati will only write out what files are supposed to be deleted. Specify the &quot;force&quot; option to actually remove them..
        /// </summary>
        internal static string ForceLong {
            get {
                return ResourceManager.GetString("ForceLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Force the removal of files.
        /// </summary>
        internal static string ForceShort {
            get {
                return ResourceManager.GetString("ForceShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the last full backup is older than the duration supplied here, Duplicati will make a full backup, otherwise an incremental.
        /// </summary>
        internal static string FullifolderthanLong {
            get {
                return ResourceManager.GetString("FullifolderthanLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The max duration between full backups.
        /// </summary>
        internal static string FullifolderthanShort {
            get {
                return ResourceManager.GetString("FullifolderthanShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When this flag is specified, Duplicati will make a full backup of all files, and ignore any incremental data..
        /// </summary>
        internal static string FullLong {
            get {
                return ResourceManager.GetString("FullLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A flag used to force full backups.
        /// </summary>
        internal static string FullShort {
            get {
                return ResourceManager.GetString("FullShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By default, Duplicati will use the AES encryption algorithm to encrypt the backup volumes, setting this flag makes Duplicati use the GNU Privacy Guard instead. GnuPG must be installed on the machine for this to work..
        /// </summary>
        internal static string GpgencryptionLong {
            get {
                return ResourceManager.GetString("GpgencryptionLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use GnuPG for encryption.
        /// </summary>
        internal static string GpgencryptionShort {
            get {
                return ResourceManager.GetString("GpgencryptionShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to the GNU Privacy Guard program. If not supplied, Duplicati will assume that the program &quot;gpg&quot; is avalible in the system path..
        /// </summary>
        internal static string GpgprogrampathLong {
            get {
                return ResourceManager.GetString("GpgprogrampathLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to GnuPG.
        /// </summary>
        internal static string GpgprogrampathShort {
            get {
                return ResourceManager.GetString("GpgprogrampathShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include files that match this filter. The filter is a &quot;file-globbing&quot; filter, much like commandline options. You can use &quot;*.txt&quot; to include all text files..
        /// </summary>
        internal static string IncludeLong {
            get {
                return ResourceManager.GetString("IncludeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include files that match this filter. The filter is a regular expression filter. You can use &quot;(.*)\.txt&quot; to include all text files..
        /// </summary>
        internal static string IncluderegexpLong {
            get {
                return ResourceManager.GetString("IncluderegexpLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include files regular expression.
        /// </summary>
        internal static string IncluderegexpShort {
            get {
                return ResourceManager.GetString("IncluderegexpShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include files.
        /// </summary>
        internal static string IncludeShort {
            get {
                return ResourceManager.GetString("IncludeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By setting this value you can limit how much bandwidth Duplicati consumes for downloads. Setting this limit can make the backups take longer, but will make Duplicati less intrusive..
        /// </summary>
        internal static string MaxdownloadprsecondLong {
            get {
                return ResourceManager.GetString("MaxdownloadprsecondLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max number of bytes to download pr. second.
        /// </summary>
        internal static string MaxdownloadprsecondShort {
            get {
                return ResourceManager.GetString("MaxdownloadprsecondShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By setting this value you can limit how much bandwidth Duplicati consumes for uploads. Setting this limit can make the backups take longer, but will make Duplicati less intrusive..
        /// </summary>
        internal static string MaxuploadprsecondLong {
            get {
                return ResourceManager.GetString("MaxuploadprsecondLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max number of bytes to upload pr. second.
        /// </summary>
        internal static string MaxuploadprsecondShort {
            get {
                return ResourceManager.GetString("MaxuploadprsecondShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you store the backups on a local disk, and prefer that they are kept unencrypted, you can turn of encryption completely by using this switch..
        /// </summary>
        internal static string NoencryptionLong {
            get {
                return ResourceManager.GetString("NoencryptionLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable encryption.
        /// </summary>
        internal static string NoencryptionShort {
            get {
                return ResourceManager.GetString("NoencryptionShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an upload or download fails, Duplicati will retry a number of times before failing. Use this to handle unstable network connections better..
        /// </summary>
        internal static string NumberofretriesLong {
            get {
                return ResourceManager.GetString("NumberofretriesLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of times to retry a failed transmission.
        /// </summary>
        internal static string NumberofretriesShort {
            get {
                return ResourceManager.GetString("NumberofretriesShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supply a passphrase that Duplicati will use to encrypt the backup volumes, making the unreadable without the passphrase..
        /// </summary>
        internal static string PassphraseLong {
            get {
                return ResourceManager.GetString("PassphraseLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passphrase used to encrypt backups.
        /// </summary>
        internal static string PassphraseShort {
            get {
                return ResourceManager.GetString("PassphraseShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By default, Duplicati will restore files from the most recent backup, use this option to select another item. You may use relative times, like &quot;-2M&quot; for a backup from two months ago..
        /// </summary>
        internal static string RestoretimeLong {
            get {
                return ResourceManager.GetString("RestoretimeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The time to restore files.
        /// </summary>
        internal static string RestoretimeShort {
            get {
                return ResourceManager.GetString("RestoretimeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to After a failed transmission, Duplicati will wait a short period before attempting again. This is usefull if the network drops out occasionally during transmissions..
        /// </summary>
        internal static string RetrydelayLong {
            get {
                return ResourceManager.GetString("RetrydelayLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time to wait between retries.
        /// </summary>
        internal static string RetrydelayShort {
            get {
                return ResourceManager.GetString("RetrydelayShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the filesystem does not support the long filenames that Duplicati uses, this switch will change the time to be a much more compact, but hard to read format. It will also make the default prefix &quot;dpl&quot;..
        /// </summary>
        internal static string ShortfilenamesLong {
            get {
                return ResourceManager.GetString("ShortfilenamesLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use short filenames.
        /// </summary>
        internal static string ShortfilenamesShort {
            get {
                return ResourceManager.GetString("ShortfilenamesShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If this path is supplied, Duplicati will store all signature files here, so re-downloads can be avoided..
        /// </summary>
        internal static string SignaturecachepathLong {
            get {
                return ResourceManager.GetString("SignaturecachepathLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A path to temporary storage.
        /// </summary>
        internal static string SignaturecachepathShort {
            get {
                return ResourceManager.GetString("SignaturecachepathShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supply a list of files seperated with semicolons, that will be added to each backup. The Duplicati GUI program uses this to store the setup database with each backup..
        /// </summary>
        internal static string SignaturecontrolfilesLong {
            get {
                return ResourceManager.GetString("SignaturecontrolfilesLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A list of control files to embed in the backups.
        /// </summary>
        internal static string SignaturecontrolfilesShort {
            get {
                return ResourceManager.GetString("SignaturecontrolfilesShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The GNU Privacy Guard can optionally sign volumes with a special key. This feature is not currently active in Duplicati..
        /// </summary>
        internal static string SignkeyLong {
            get {
                return ResourceManager.GetString("SignkeyLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sign key for GnuPG.
        /// </summary>
        internal static string SignkeyShort {
            get {
                return ResourceManager.GetString("SignkeyShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the hash for the volume does not match, Duplicati will refuse to use the backup. Supply this flag to allow Duplicati to proceed anyway..
        /// </summary>
        internal static string SkipfilehashchecksLong {
            get {
                return ResourceManager.GetString("SkipfilehashchecksLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set this flag to skip hash checks.
        /// </summary>
        internal static string SkipfilehashchecksShort {
            get {
                return ResourceManager.GetString("SkipfilehashchecksShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option allows you to exclude files that are larger than the given value. Use this to prevent backups becoming extremely large..
        /// </summary>
        internal static string SkipfileslargerthanLong {
            get {
                return ResourceManager.GetString("SkipfileslargerthanLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A size string that limits the size of files being backed up.
        /// </summary>
        internal static string SkipfileslargerthanShort {
            get {
                return ResourceManager.GetString("SkipfileslargerthanShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicati will use the system default temporary folder. This option can be used to supply an alternative folder for temporary storage..
        /// </summary>
        internal static string TempdirLong {
            get {
                return ResourceManager.GetString("TempdirLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temporary storage folder.
        /// </summary>
        internal static string TempdirShort {
            get {
                return ResourceManager.GetString("TempdirShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selects another thread priority for the process. Use this to set Duplicati to be more or less CPU intensive..
        /// </summary>
        internal static string ThreadpriorityLong {
            get {
                return ResourceManager.GetString("ThreadpriorityLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thread priority.
        /// </summary>
        internal static string ThreadpriorityShort {
            get {
                return ResourceManager.GetString("ThreadpriorityShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Per default, Duplicati will use the colon &quot;:&quot; character to seperate the time fields in the filename. However, on some filesystem, notably windows, this character is not allowed. Use this option to use another character..
        /// </summary>
        internal static string TimeseparatorLong {
            get {
                return ResourceManager.GetString("TimeseparatorLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup volume filename timeseperator.
        /// </summary>
        internal static string TimeseparatorShort {
            get {
                return ResourceManager.GetString("TimeseparatorShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option can place an upper limit on the total size of each backup. Note that if this flag is specified the backup may not contain all files, even for a full backup..
        /// </summary>
        internal static string TotalsizeLong {
            get {
                return ResourceManager.GetString("TotalsizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of bytes generated by each backup run.
        /// </summary>
        internal static string TotalsizeShort {
            get {
                return ResourceManager.GetString("TotalsizeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option can change the default volume size. Changing the size can be usefull if the backend has a limit on the size of each individual file.
        /// </summary>
        internal static string VolsizeLong {
            get {
                return ResourceManager.GetString("VolsizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A size string that limits the size of the volumes.
        /// </summary>
        internal static string VolsizeShort {
            get {
                return ResourceManager.GetString("VolsizeShort", resourceCulture);
            }
        }
    }
}
