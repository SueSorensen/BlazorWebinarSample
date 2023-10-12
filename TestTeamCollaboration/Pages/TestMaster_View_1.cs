using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Pages;
using TeamCollaboration.Financial;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestMaster_View_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Master_View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}