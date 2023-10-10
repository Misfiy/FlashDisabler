using Exiled.API.Interfaces;
using PlayerRoles;

namespace FlashDisabler
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;
		public bool Debug { get; set; } = false;
		public List<RoleTypeId> IgnoredRoles { get; set; } = new()
		{
			RoleTypeId.Scp939,
		};
	}
}
