﻿namespace Nop.Plugin.Misc.GiftProvider.Domain;

/// <summary>
/// Represents a discount limitation type
/// </summary>
public enum GiftLimitationType
{
    /// <summary>
    /// None
    /// </summary>
    Unlimited = 0,

    /// <summary>
    /// N Times Only
    /// </summary>
    NTimesOnly = 15,

    /// <summary>
    /// N Times Per Customer
    /// </summary>
    NTimesPerCustomer = 25
}
