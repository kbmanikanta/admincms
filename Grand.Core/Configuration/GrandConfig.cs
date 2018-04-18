
namespace Grand.Core.Configuration
{
    /// <summary>
    /// Represents a GrandConfig
    /// </summary>
    public partial class GrandConfig 
    {
        /// <summary>
        /// Indicates whether we should ignore startup tasks
        /// </summary>
        public bool IgnoreStartupTasks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to clear /Plugins/bin directory on application startup
        /// </summary>
        public bool ClearPluginShadowDirectoryOnStartup { get; set; }

        /// <summary>
        /// Path to database with user agent strings
        /// </summary>
        public string UserAgentStringsPath { get; set; }

        /// <summary>
        /// Indicates whether we should use Redis server for caching (instead of default in-memory caching)
        /// </summary>
        public bool RedisCachingEnabled { get; set; }
        /// <summary>
        /// Redis connection string. Used when Redis caching is enabled
        /// </summary>
        public string RedisCachingConnectionString { get; set; }


        /// <summary>
        /// A value indicating whether the site is run on multiple instances (e.g. web farm, Windows Azure with multiple instances, etc).
        /// Do not enable it if you run on Azure but use one instance only
        /// </summary>
        public bool MultipleInstancesEnabled { get; set; }

        /// <summary>
        /// A value indicating whether the site is run on Windows Azure Web Apps
        /// </summary>
        public bool RunOnAzureWebApps { get; set; }

        /// <summary>
        /// Connection string for Azure BLOB storage
        /// </summary>
        public string AzureBlobStorageConnectionString { get; set; }

        /// <summary>
        /// Container name for Azure BLOB storage
        /// </summary>
        public string AzureBlobStorageContainerName { get; set; }
        /// <summary>
        /// End point for Azure BLOB storage
        /// </summary>
        public string AzureBlobStorageEndPoint { get; set; }

        /// <summary>
        /// Amazon Access Key
        /// </summary>
        public string AmazonAwsAccessKeyId { get; set; }

        /// <summary>
        /// Amazon Secret Access Key
        /// </summary>
        public string AmazonAwsSecretAccessKey { get; set; }

        /// <summary>
        /// Amazon Bucket Name using for identifying resources
        /// </summary>
        public string AmazonBucketName { get; set; }

        /// <summary>
        /// Amazon Region 
        /// http://docs.amazonwebservices.com/AmazonS3/latest/BucketConfiguration.html#LocationSelection
        /// </summary>
        public string AmazonRegion { get; set; }

        /// <summary>
        /// A value indicating whether a store owner can install sample data during installation
        /// </summary>
        public bool DisableSampleDataDuringInstallation { get; set; }

        
        /// <summary>
        /// A list of plugins ignored during installation
        /// </summary>
        public string PluginsIgnoredDuringInstallation { get; set; }

        /// <summary>
        /// Gets or sets a value of "Cache-Control" header value for static content
        /// </summary>
        public string StaticFilesCacheControl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to display the full error in production environment.
        /// It's ignored (always enabled) in development environment
        /// </summary>
        public bool DisplayFullErrorStack { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we compress response
        /// </summary>
        public bool UseResponseCompression { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ignore InstallUrlMiddleware
        /// </summary>
        public bool IgnoreInstallUrlMiddleware { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ignore IgnoreUsePoweredByMiddleware
        /// </summary>
        public bool IgnoreUsePoweredByMiddleware { get; set; }
    }
}
