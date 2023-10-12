using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Pages.Master_View;
using TeamCollaboration.Northwind;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestBacklog
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbInputModule),
				typeof(IgbTabsModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Backlog>();
			Assert.NotNull(componentUnderTest);
		}
	}
}