using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Security;
using Nop.Services.Security;

namespace Nop.Plugin.Misc.GiftProvider.Services;

/// <summary>
/// Standard permission provider
/// </summary>
public class GiftPermissionProvider : IPermissionProvider
{
    //admin area permissions
    public static readonly PermissionRecord ManageGifts = new() { Name = "Admin area. Manage Gifts", SystemName = "ManageGifts", Category = "Promo" };

    /// <summary>
    /// Get permissions
    /// </summary>
    /// <returns>Permissions</returns>
    public virtual IEnumerable<PermissionRecord> GetPermissions()
    {
        return new[]
        {
            ManageGifts
        };
    }

    /// <summary>
    /// Get default permissions
    /// </summary>
    /// <returns>Permissions</returns>
    public virtual HashSet<(string systemRoleName, PermissionRecord[] permissions)> GetDefaultPermissions()
    {
        return new HashSet<(string, PermissionRecord[])>
            {
                (
                    NopCustomerDefaults.AdministratorsRoleName,
                    new[]
                    {
                        ManageGifts
                    }
                )
            };
    }
}
