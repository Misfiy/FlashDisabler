using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;

namespace FlashDisabler
{
	public class EventHandler
	{
		public void OnExplodingGrenade(ExplodingGrenadeEventArgs ev)
		{
			if(ev.Projectile.Type == ItemType.GrenadeFlash)
			{
				foreach(Player player in ev.TargetsToAffect.Where(p => Plugin.Instance.Config.IgnoredRoles.Contains(p.Role.Type)))
				{
					ev.TargetsToAffect.Remove(player);
				}
			}
		}
	}
}
