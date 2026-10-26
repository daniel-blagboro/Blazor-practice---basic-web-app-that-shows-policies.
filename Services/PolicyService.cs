
using Canopius.PolicyDashboard.Blazor.Models;

namespace Canopius.PolicyDashboard.Blazor.Services;

public class PolicyService
{
    private readonly List<Policy> policies = new()
    {
        new Policy
        {
            PolicyReference = "POL-1001",
            InsuredCompany = "Northstar Insurance Ltd",
            Status = "Active"
        },
        new Policy
        {
            PolicyReference = "POL-1002",
            InsuredCompany = "Greenfield Trading Ltd",
            Status = "Pending"
        },
        new Policy
        {
            PolicyReference = "POL-1003",
            InsuredCompany = "Westbrook Services Ltd",
            Status = "Active"
        }
    };

    public List<Policy> GetPolicies()
    {
        return policies;
    }
}
