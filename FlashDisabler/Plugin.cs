using Exiled.API.Features;

namespace FlashDisabler
{
	public class Plugin : Plugin<Config>
	{
		public override string Name { get; } = "FlashDisabler";
		public override string Author { get; } = "@misfiy";
		public override Version RequiredExiledVersion { get; } = new(8, 2, 1);
		public override Version Version { get; } = new(1, 0, 0);

		public static Plugin Instance { get; private set; } = null!;

		public EventHandler eventHandler { get; private set; } = null!;

		public override void OnEnabled()
		{
			Instance = this;
			eventHandler = new();

			Exiled.Events.Handlers.Map.ExplodingGrenade += eventHandler.OnExplodingGrenade;

			base.OnEnabled();
		}

		public override void OnDisabled()
		{
			Exiled.Events.Handlers.Map.ExplodingGrenade -= eventHandler.OnExplodingGrenade;
			eventHandler = null!;

			Instance = null!;
			base.OnDisabled();
		}
	}
}