using System.Threading.Tasks;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.GiftProvider.Services;

/// <summary>
/// Represents a discount requirement rule
/// </summary>
public partial interface IGiftRequirementRule : IPlugin
{
    /// <summary>
    /// Check discount requirement
    /// </summary>
    /// <param name="request">Object that contains all information required to check the requirement (Current customer, discount, etc)</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the result
    /// </returns>
    Task<GiftRequirementValidationResult> CheckRequirementAsync(GiftRequirementValidationRequest request);

    /// <summary>
    /// Get URL for rule configuration
    /// </summary>
    /// <param name="discountId">Gift identifier</param>
    /// <param name="discountRequirementId">Gift requirement identifier (if editing)</param>
    /// <returns>URL</returns>
    string GetConfigurationUrl(int discountId, int? discountRequirementId);
}
