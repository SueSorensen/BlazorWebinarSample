using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Shared;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbDropdownHeaderModule),
				typeof(IgbIconButtonModule),
				typeof(IgbAvatarModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbInputModule),
				typeof(IgbBadgeModule));
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}