using System;

namespace Web.Social
{
	public class TwitterProxy : ISocialService, IDisposable
	{
		private readonly string _targetUrl;

		public TwitterProxy(string targetUrl)
		{
			_targetUrl = targetUrl;
		}

		public SharingResult ShareStatus(string status)
		{
			//Pretend this is actually posting the status to Twitter! :)
			Console.WriteLine("Posting status to " + _targetUrl);

			return new SharingResult
			{
				SentTo = _targetUrl,
				Succeeded = true
			};
		}

		public void Dispose()
		{
			Console.WriteLine("Disposing of proxy!");
		}
	}
}