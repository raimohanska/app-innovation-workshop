namespace ContosoFieldService.Helpers
{
    public static class Constants
    {
        // Backend API
        public static string BaseUrl = "https://reaktorappinnovation.azurewebsites.net/api/";
        public static string ApiManagementKey = "d0a91897ef934a8aa9e52009fff66eed";

        // Visual Studio App Center
        public static string AppCenterIOSKey = "76504461-a4d3-4776-941f-bbee7b0b33cb";
        public static string AppCenterAndroidKey = "490fd451-d367-4d81-a5db-5ba1f8c6aec0";
        public static string AppCenterUWPKey = "307f4513-2d0d-4646-a4cc-fc2e2e7859a8";

        // Azure Active Directory B2C
        public static string Tenant = "reaktorappinn.onmicrosoft.com";
        public static string ApplicationId = "5d923c8b-1fc9-4aa0-9cb2-24d78c7e523a";
        public static string SignUpAndInPolicy = "B2C_1_GenericSignUpSignIn";
        public static string[] Scopes = { "https://reaktorappinn.onmicrosoft.com/backend/read_only" };
    }
}
