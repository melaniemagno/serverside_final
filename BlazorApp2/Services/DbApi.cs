namespace BlazorApp2.Services
{
	public class DbApi : FileAPI
	{
		protected override string BASE_ADDR => "http://localhost:8000";
	}
}
