namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum FederatedIdpMfaBehavior {
        AcceptIfMfaDoneByFederatedIdp,
        EnforceMfaByFederatedIdp,
        RejectMfaByFederatedIdp,
        UnknownFutureValue,
    }
}
