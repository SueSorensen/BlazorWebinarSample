using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Pages.Login;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestCreate_Account
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Create_Account>();
			Assert.NotNull(componentUnderTest);
		}
	}
}