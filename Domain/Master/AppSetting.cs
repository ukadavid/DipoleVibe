global using Domain.Common;

using System;

namespace Domain.Master
{
	public class AppSetting : BaseEntity 
	{
		// Authentication and JWT
		public string JwtSecretKey { get; set; }
		public string JwtIssuer { get; set; }
		public string JwtAudience { get; set; }


		// Database connection string
		public string DatabaseConnectionString { get; set; }

		// Speech-to-text Service
		public string SpeechToTextApiKey { get; set; }

        // Video Storage String using Azure Blob Storage
		public string VideoStorageConnectionString { get; set; }

    }
}

