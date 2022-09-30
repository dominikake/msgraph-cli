namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum WindowsUserAccountControlSettings {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Always notify.</summary>
        AlwaysNotify,
        /// <summary>Notify on app changes.</summary>
        NotifyOnAppChanges,
        /// <summary>Notify on app changes without dimming desktop.</summary>
        NotifyOnAppChangesWithoutDimming,
        /// <summary>Never notify.</summary>
        NeverNotify,
    }
}
