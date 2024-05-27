using Infrastructure.Entites;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;



namespace JSBackend.Components.Pages.Account.Shared;

internal static class IdentityComponentsEndpointRouteBuilderExtensions
{
    public static IEndpointConventionBuilder MapAdditionalIdentityEndpoints(this IEndpointRouteBuilder endpoints)
    {
        ArgumentNullException.ThrowIfNull(endpoints);

        var accountGroup = endpoints.MapGroup("/Account");

        accountGroup.MapPost("/Logout", async (
            ClaimsPrincipal user,
            SignInManager<UserEntity> signInManager,
            [FromForm] string returnUrl,
            HttpContext httpContext) =>
        {
            await signInManager.SignOutAsync();
            return TypedResults.LocalRedirect("/signin");
        }).RequireAuthorization();

        return accountGroup;
    }
}
