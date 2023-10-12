using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Pages.Login;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestSign_In
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbInputModule),
				typeof(IgbCheckboxModule));
			var componentUnderTest = ctx.RenderComponent<Sign_In>();
			Assert.NotNull(componentUnderTest);
		}
	}
}