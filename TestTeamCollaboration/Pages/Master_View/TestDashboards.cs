using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Pages.Master_View;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestDashboards
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<Dashboards>();
			Assert.NotNull(componentUnderTest);
		}
	}
}