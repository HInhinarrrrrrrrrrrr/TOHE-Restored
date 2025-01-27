using AmongUs.GameOptions;
using System.Linq;
using TOHE.Roles.Crewmate;
using TOHE.Roles.Neutral;

namespace TOHE;

internal static class CustomRolesHelper
{
    public static CustomRoles GetVNRole(this CustomRoles role) // ��Ӧԭ��ְҵ
    {
        return role.IsVanilla()
            ? role
            : role switch
            {
                CustomRoles.Sniper => CustomRoles.Shapeshifter,
                CustomRoles.Jester => Options.JesterCanVent.GetBool() ? CustomRoles.Engineer : CustomRoles.Crewmate,
                CustomRoles.Mayor => Options.MayorHasPortableButton.GetBool() ? CustomRoles.Engineer : CustomRoles.Crewmate,
                CustomRoles.Vulture => Vulture.CanVent.GetBool() ? CustomRoles.Engineer : CustomRoles.Crewmate,
                CustomRoles.Opportunist => CustomRoles.Crewmate,
                CustomRoles.Vindicator => CustomRoles.Impostor,
                CustomRoles.Snitch => CustomRoles.Crewmate,
                CustomRoles.ParityCop => CustomRoles.Crewmate,
                CustomRoles.Marshall => CustomRoles.Crewmate,
                CustomRoles.SabotageMaster => CustomRoles.Engineer,
                CustomRoles.Mafia => Options.LegacyMafia.GetBool() ? CustomRoles.Shapeshifter : CustomRoles.Impostor,
                CustomRoles.Terrorist => CustomRoles.Engineer,
                CustomRoles.Executioner => CustomRoles.Crewmate,
                CustomRoles.Juggernaut => CustomRoles.Impostor,
                CustomRoles.Lawyer => CustomRoles.Crewmate,
                CustomRoles.Vampire => CustomRoles.Impostor,
                CustomRoles.Poisoner => CustomRoles.Impostor,
                CustomRoles.NSerialKiller => CustomRoles.Impostor,
                CustomRoles.Maverick => CustomRoles.Impostor,
                CustomRoles.CursedSoul => CustomRoles.Impostor,
                CustomRoles.Parasite => CustomRoles.Impostor,
                CustomRoles.BountyHunter => CustomRoles.Shapeshifter,
                CustomRoles.Trickster => CustomRoles.Impostor,
                CustomRoles.Witch => CustomRoles.Impostor,
                CustomRoles.ShapeMaster => CustomRoles.Shapeshifter,
                CustomRoles.ShapeshifterTOHE => CustomRoles.Shapeshifter,
                CustomRoles.ImpostorTOHE => CustomRoles.Impostor,
                CustomRoles.EvilDiviner => CustomRoles.Impostor,
                CustomRoles.Ritualist => CustomRoles.Impostor,
                CustomRoles.Pickpocket => CustomRoles.Impostor,
                CustomRoles.Traitor => CustomRoles.Impostor,
                CustomRoles.HexMaster => CustomRoles.Impostor,
                CustomRoles.Wildling => CustomRoles.Shapeshifter,
                CustomRoles.Morphling => CustomRoles.Shapeshifter,
                CustomRoles.Warlock => CustomRoles.Shapeshifter,
                CustomRoles.SerialKiller => CustomRoles.Shapeshifter,
                CustomRoles.FireWorks => CustomRoles.Shapeshifter,
                CustomRoles.SpeedBooster => CustomRoles.Crewmate,
                CustomRoles.Dictator => CustomRoles.Crewmate,
                CustomRoles.Mare => CustomRoles.Impostor,
                CustomRoles.Inhibitor => CustomRoles.Impostor,
                CustomRoles.Saboteur => CustomRoles.Impostor,
                CustomRoles.Doctor => CustomRoles.Scientist,
                CustomRoles.ScientistTOHE => CustomRoles.Scientist,
                CustomRoles.Tracefinder => CustomRoles.Scientist,
                CustomRoles.Puppeteer => CustomRoles.Impostor,
                CustomRoles.NWitch => CustomRoles.Impostor,
                CustomRoles.TimeThief => CustomRoles.Impostor,
                CustomRoles.EvilTracker => CustomRoles.Shapeshifter,
                CustomRoles.Paranoia => CustomRoles.Engineer,
                CustomRoles.EngineerTOHE => CustomRoles.Engineer,
                CustomRoles.Miner => CustomRoles.Shapeshifter,
                CustomRoles.Psychic => CustomRoles.Crewmate,
                CustomRoles.Needy => CustomRoles.Crewmate,
                CustomRoles.Twister => CustomRoles.Shapeshifter,
                CustomRoles.SuperStar => CustomRoles.Crewmate,
                CustomRoles.Hacker => CustomRoles.Shapeshifter,
                CustomRoles.Assassin => CustomRoles.Shapeshifter,
                CustomRoles.Luckey => CustomRoles.Crewmate,
                CustomRoles.CyberStar => CustomRoles.Crewmate,
                CustomRoles.Escapee => CustomRoles.Shapeshifter,
                CustomRoles.NiceGuesser => CustomRoles.Crewmate,
                CustomRoles.EvilGuesser => CustomRoles.Impostor,
                CustomRoles.Detective => CustomRoles.Crewmate,
                CustomRoles.Minimalism => CustomRoles.Impostor,
                CustomRoles.God => CustomRoles.Crewmate,
                CustomRoles.GuardianAngelTOHE => CustomRoles.GuardianAngel,
                CustomRoles.Zombie => CustomRoles.Impostor,
                CustomRoles.Mario => CustomRoles.Engineer,
                CustomRoles.AntiAdminer => CustomRoles.Impostor,
                CustomRoles.Sans => CustomRoles.Impostor,
                CustomRoles.Bomber => CustomRoles.Shapeshifter,
                CustomRoles.BoobyTrap => CustomRoles.Impostor,
                CustomRoles.Scavenger => CustomRoles.Impostor,
                CustomRoles.Transporter => CustomRoles.Crewmate,
                CustomRoles.Veteran => CustomRoles.Engineer,
                CustomRoles.Capitalism => CustomRoles.Impostor,
                CustomRoles.Bodyguard => CustomRoles.Crewmate,
                CustomRoles.Grenadier => CustomRoles.Engineer,
                CustomRoles.Gangster => CustomRoles.Impostor,
                CustomRoles.Cleaner => CustomRoles.Impostor,
                CustomRoles.Medusa => CustomRoles.Impostor,
                CustomRoles.Konan => CustomRoles.Crewmate,
                CustomRoles.Divinator => CustomRoles.Crewmate,
                CustomRoles.Oracle => CustomRoles.Crewmate,
                CustomRoles.BallLightning => CustomRoles.Impostor,
                CustomRoles.Greedier => CustomRoles.Impostor,
                CustomRoles.Workaholic => CustomRoles.Engineer,
                CustomRoles.CursedWolf => CustomRoles.Impostor,
                CustomRoles.Jinx => CustomRoles.Impostor,
                CustomRoles.Collector => CustomRoles.Crewmate,
                CustomRoles.Glitch => CustomRoles.Crewmate,
                CustomRoles.ImperiusCurse => CustomRoles.Shapeshifter,
                CustomRoles.QuickShooter => CustomRoles.Shapeshifter,
                CustomRoles.Eraser => CustomRoles.Impostor,
                CustomRoles.OverKiller => CustomRoles.Impostor,
                CustomRoles.Hangman => CustomRoles.Shapeshifter,
                CustomRoles.Sunnyboy => CustomRoles.Scientist,
                CustomRoles.Phantom => Options.PhantomCanVent.GetBool() ? CustomRoles.Engineer : CustomRoles.Crewmate,
                CustomRoles.Judge => CustomRoles.Crewmate,
                CustomRoles.Councillor => CustomRoles.Impostor,
                CustomRoles.Mortician => CustomRoles.Crewmate,
                CustomRoles.Mediumshiper => CustomRoles.Crewmate,
                CustomRoles.Bard => CustomRoles.Impostor,
                CustomRoles.Swooper => CustomRoles.Impostor,
                CustomRoles.Wraith => CustomRoles.Impostor,
                CustomRoles.Crewpostor => CustomRoles.Engineer,
                CustomRoles.Observer => CustomRoles.Crewmate,
                CustomRoles.DovesOfNeace => CustomRoles.Engineer,
                CustomRoles.Infectious => CustomRoles.Impostor,
                CustomRoles.Virus => CustomRoles.Virus,
                CustomRoles.Disperser => CustomRoles.Shapeshifter,
                CustomRoles.Camouflager => CustomRoles.Shapeshifter,
                CustomRoles.Dazzler => CustomRoles.Shapeshifter,
                CustomRoles.Devourer => CustomRoles.Shapeshifter,
                CustomRoles.Deathpact => CustomRoles.Shapeshifter,
             //   CustomRoles.Monarch => CustomRoles.Impostor,
                CustomRoles.Bloodhound => CustomRoles.Crewmate,
                CustomRoles.Tracker => CustomRoles.Crewmate,
                CustomRoles.Merchant => CustomRoles.Crewmate,
                CustomRoles.Retributionist => CustomRoles.Crewmate,
                CustomRoles.Guardian => CustomRoles.Crewmate,
                CustomRoles.Addict => CustomRoles.Engineer,
                CustomRoles.Chameleon => CustomRoles.Engineer,
                CustomRoles.Spiritcaller => CustomRoles.Impostor,
                CustomRoles.EvilSpirit => CustomRoles.GuardianAngel,
                CustomRoles.Lurker => CustomRoles.Impostor,
                _ => role.IsImpostor() ? CustomRoles.Impostor : CustomRoles.Crewmate,
            };
    }

        public static CustomRoles GetErasedRole(this CustomRoles role) // ��Ӧԭ��ְҵ
    {
        return role.IsVanilla()
            ? role
            : role switch
            {
                CustomRoles.Tracker => CustomRoles.Crewmate,
                CustomRoles.Mayor => Options.MayorHasPortableButton.GetBool() ? CustomRoles.EngineerTOHE : CustomRoles.Crewmate,
                CustomRoles.Observer => CustomRoles.Crewmate,
                CustomRoles.DovesOfNeace => CustomRoles.EngineerTOHE,
                CustomRoles.Judge => CustomRoles.Crewmate,
                CustomRoles.Mortician => CustomRoles.Crewmate,
                CustomRoles.Mediumshiper => CustomRoles.Crewmate,
                CustomRoles.Glitch => CustomRoles.Crewmate,
                CustomRoles.Bodyguard => CustomRoles.Crewmate,
                CustomRoles.ParityCop => CustomRoles.Crewmate,
                CustomRoles.Grenadier => CustomRoles.EngineerTOHE,
                CustomRoles.Transporter => CustomRoles.Crewmate,
                CustomRoles.Veteran => CustomRoles.Engineer,
                CustomRoles.GuardianAngelTOHE => CustomRoles.GuardianAngel,
                CustomRoles.Detective => CustomRoles.Crewmate,
                CustomRoles.NiceGuesser => CustomRoles.Crewmate,
                CustomRoles.Luckey => CustomRoles.Crewmate,
                CustomRoles.CyberStar => CustomRoles.Crewmate,
                CustomRoles.Psychic => CustomRoles.Crewmate,
                CustomRoles.Needy => CustomRoles.Crewmate,
                CustomRoles.SuperStar => CustomRoles.Crewmate,
                CustomRoles.Paranoia => CustomRoles.EngineerTOHE,
                CustomRoles.EngineerTOHE => CustomRoles.EngineerTOHE,
                CustomRoles.Doctor => CustomRoles.ScientistTOHE,
                CustomRoles.ScientistTOHE => CustomRoles.ScientistTOHE,
                CustomRoles.Tracefinder => CustomRoles.ScientistTOHE,
                CustomRoles.SpeedBooster => CustomRoles.Crewmate,
                CustomRoles.Dictator => CustomRoles.Crewmate,
                CustomRoles.Snitch => CustomRoles.Crewmate,
                CustomRoles.Marshall => CustomRoles.Crewmate,
                CustomRoles.SabotageMaster => CustomRoles.EngineerTOHE,
                CustomRoles.Retributionist => CustomRoles.Crewmate,
                CustomRoles.Monarch => CustomRoles.Crewmate,
                CustomRoles.Deputy => CustomRoles.Crewmate,
                CustomRoles.Guardian => CustomRoles.Crewmate,
                CustomRoles.Addict => CustomRoles.EngineerTOHE,
                CustomRoles.Oracle => CustomRoles.EngineerTOHE,
                CustomRoles.Chameleon => CustomRoles.EngineerTOHE,
                _ => role.IsImpostor() ? CustomRoles.Impostor : CustomRoles.Crewmate,
            };
    }

    public static RoleTypes GetDYRole(this CustomRoles role) // ��Ӧԭ��ְҵ����ְҵ��
    {
        return role switch
        {
            //SoloKombat
            CustomRoles.KB_Normal => RoleTypes.Impostor,
            //Standard
            CustomRoles.Sheriff => RoleTypes.Impostor,
            CustomRoles.CursedSoul => RoleTypes.Impostor,
            CustomRoles.Monarch => RoleTypes.Impostor,
            CustomRoles.Deputy => RoleTypes.Impostor,
            CustomRoles.Arsonist => RoleTypes.Impostor,
            CustomRoles.Jackal => RoleTypes.Impostor,
            CustomRoles.Medusa => RoleTypes.Impostor,
            CustomRoles.Sidekick => RoleTypes.Impostor,
            CustomRoles.SwordsMan => RoleTypes.Impostor,
            CustomRoles.Innocent => RoleTypes.Impostor,
            CustomRoles.Pelican => RoleTypes.Impostor,
            CustomRoles.Counterfeiter => RoleTypes.Impostor,
            CustomRoles.Pursuer => RoleTypes.Impostor,
            CustomRoles.Revolutionist => RoleTypes.Impostor,
            CustomRoles.FFF => RoleTypes.Impostor,
            CustomRoles.Medicaler => RoleTypes.Impostor,
            CustomRoles.Gamer => RoleTypes.Impostor,
            CustomRoles.HexMaster => RoleTypes.Impostor,
            CustomRoles.Wraith => RoleTypes.Impostor,
       //     CustomRoles.Chameleon => RoleTypes.Impostor,
            CustomRoles.Juggernaut => RoleTypes.Impostor,
            CustomRoles.Jinx => RoleTypes.Impostor,
            CustomRoles.DarkHide => RoleTypes.Impostor,
            CustomRoles.Provocateur => RoleTypes.Impostor,
            CustomRoles.BloodKnight => RoleTypes.Impostor,
            CustomRoles.Poisoner => RoleTypes.Impostor,
            CustomRoles.NSerialKiller => RoleTypes.Impostor,
            CustomRoles.Maverick => RoleTypes.Impostor,
            CustomRoles.Parasite => RoleTypes.Impostor,
            CustomRoles.NWitch => RoleTypes.Impostor,
            CustomRoles.Totocalcio => RoleTypes.Impostor,
            CustomRoles.Succubus => RoleTypes.Impostor,
            CustomRoles.Infectious => RoleTypes.Impostor,
            CustomRoles.Virus => RoleTypes.Impostor,
            CustomRoles.Farseer => RoleTypes.Impostor,
            CustomRoles.Ritualist => RoleTypes.Impostor,
            CustomRoles.Pickpocket => RoleTypes.Impostor,
            CustomRoles.Traitor => RoleTypes.Impostor,
            CustomRoles.Spiritcaller => RoleTypes.Impostor,
            _ => RoleTypes.GuardianAngel
        };
    }
    public static bool IsAdditionRole(this CustomRoles role) // �Ƿ񸽼�
    {
        return role is
            CustomRoles.Lovers or
            CustomRoles.LastImpostor or
            CustomRoles.Ntr or
            CustomRoles.Madmate or
            CustomRoles.Watcher or
            CustomRoles.Flashman or
            CustomRoles.Lighter or
            CustomRoles.Seer or
            CustomRoles.Bait or
            CustomRoles.Gravestone or
            CustomRoles.Trapper or
            CustomRoles.Brakar or
            CustomRoles.Oblivious or
            CustomRoles.Bewilder or
            CustomRoles.Knighted or
            CustomRoles.Workhorse or
            CustomRoles.Fool or
            CustomRoles.Autopsy or
            CustomRoles.Necroview or
            CustomRoles.Avanger or
            CustomRoles.Youtuber or
            CustomRoles.Soulless or
            CustomRoles.Pessimist or
            CustomRoles.Egoist or
            CustomRoles.TicketsStealer or
            CustomRoles.DualPersonality or
            CustomRoles.Mimic or
            CustomRoles.Reach or
            CustomRoles.Charmed or
            CustomRoles.Infected or
            CustomRoles.Onbound or
            CustomRoles.Lazy or
       //     CustomRoles.Reflective or
            CustomRoles.Rascal or
            CustomRoles.Contagious or
            CustomRoles.Guesser or
            CustomRoles.Rogue or
            CustomRoles.Unreportable or
            CustomRoles.Lucky or
            CustomRoles.DoubleShot or
            CustomRoles.EvilSpirit;
    }
    public static bool IsNonNK(this CustomRoles role) // ROLE ASSIGNING, NOT NEUTRAL TYPE
    {
        return role is
            CustomRoles.Jester or
            CustomRoles.Terrorist or
            CustomRoles.Opportunist or
            CustomRoles.Arsonist or
            CustomRoles.Executioner or
            CustomRoles.Mario or
            CustomRoles.Lawyer or
            CustomRoles.God or
            CustomRoles.Innocent or
            CustomRoles.Vulture or
            CustomRoles.NWitch or
            CustomRoles.Pursuer or
            CustomRoles.Revolutionist or
            CustomRoles.Provocateur or
            CustomRoles.Gamer or
            CustomRoles.FFF or
            CustomRoles.Workaholic or
            CustomRoles.Pelican or
            CustomRoles.Collector or
            CustomRoles.Sunnyboy or
            CustomRoles.Maverick or
            CustomRoles.CursedSoul or
            CustomRoles.Phantom or
            CustomRoles.Totocalcio or
            CustomRoles.Succubus;
    }
    public static bool IsNK(this CustomRoles role) // �Ƿ��������
    {
        return role is
            CustomRoles.Jackal or
            CustomRoles.Sidekick or
            CustomRoles.HexMaster or
            CustomRoles.Infectious or
            CustomRoles.Wraith or
            CustomRoles.Crewpostor or
            CustomRoles.Medusa or
            CustomRoles.Pelican or
            CustomRoles.DarkHide or
            CustomRoles.Juggernaut or
            CustomRoles.Jinx or
            CustomRoles.Poisoner or
            CustomRoles.Parasite or
            CustomRoles.NSerialKiller or
            CustomRoles.Ritualist or
            CustomRoles.Pickpocket or
            CustomRoles.Traitor or
            CustomRoles.Virus or
            CustomRoles.BloodKnight or
            CustomRoles.Spiritcaller;
    }
    public static bool IsSnitchTarget(this CustomRoles role) // �Ƿ��������
    {
        return role is
            CustomRoles.Jackal or
            CustomRoles.Sidekick or
            CustomRoles.HexMaster or
            CustomRoles.Infectious or
            CustomRoles.Wraith or
            CustomRoles.Crewpostor or
            CustomRoles.Juggernaut or
            CustomRoles.Jinx or
            CustomRoles.DarkHide or
            CustomRoles.Poisoner or
            CustomRoles.Parasite or
            CustomRoles.NSerialKiller or
            CustomRoles.Ritualist or
            CustomRoles.Pickpocket or
            CustomRoles.Traitor or
            CustomRoles.Medusa or
            CustomRoles.Gamer or
            CustomRoles.Pelican or
            CustomRoles.Virus or
            CustomRoles.Succubus or
            CustomRoles.BloodKnight or
            CustomRoles.Spiritcaller;
    }
    public static bool IsNE(this CustomRoles role) // �Ƿ�����
    {
        return role is
            CustomRoles.Jester or
            CustomRoles.Gamer or
            CustomRoles.Arsonist or
            CustomRoles.Executioner or
            CustomRoles.Innocent;
    }
    public static bool IsNB(this CustomRoles role) // �Ƿ�����
    {
        return role is
            CustomRoles.Opportunist or
            CustomRoles.Lawyer or
            CustomRoles.NWitch or
            CustomRoles.God or
            CustomRoles.Pursuer or
            CustomRoles.Sunnyboy or
            CustomRoles.Maverick or
            CustomRoles.Totocalcio;
    }
    public static bool IsNC(this CustomRoles role) // �Ƿ�����
    {
        return role is
            CustomRoles.Mario or
            CustomRoles.Terrorist or
            CustomRoles.Revolutionist or
            CustomRoles.FFF or
            CustomRoles.Vulture or
            CustomRoles.Famine or
            CustomRoles.Baker or
            CustomRoles.CursedSoul or
            CustomRoles.Phantom or
            CustomRoles.Workaholic or
            CustomRoles.Collector or
            CustomRoles.Provocateur;
    }
    public static bool IsNeutralKilling(this CustomRoles role) //�Ƿ�а������������򵥶�ʤ����������
    {
        return role is
            CustomRoles.Terrorist or
            CustomRoles.Arsonist or
            CustomRoles.Juggernaut or
            CustomRoles.Medusa or
            CustomRoles.Jinx or
            CustomRoles.Jackal or
            CustomRoles.Sidekick or
            CustomRoles.God or
            CustomRoles.Mario or
            CustomRoles.Innocent or
            CustomRoles.Pelican or
            CustomRoles.Wraith or
            CustomRoles.HexMaster or
            CustomRoles.Egoist or
            CustomRoles.Gamer or
            CustomRoles.Parasite or
            CustomRoles.DarkHide or
            CustomRoles.Workaholic or
            CustomRoles.Collector or
            CustomRoles.Traitor or
            CustomRoles.Poisoner or
            CustomRoles.NSerialKiller or
            CustomRoles.Ritualist or
            CustomRoles.Pickpocket or
            CustomRoles.Traitor or
            CustomRoles.BloodKnight or
            CustomRoles.Infectious or
            CustomRoles.Virus or
            CustomRoles.Succubus or
            CustomRoles.Spiritcaller;
    }
    public static bool IsCK(this CustomRoles role) // �Ƿ������Ա
    {
        return role is
            CustomRoles.SwordsMan or
            CustomRoles.Veteran or
            CustomRoles.Bodyguard or
            CustomRoles.NiceGuesser or
            CustomRoles.Counterfeiter or
            CustomRoles.Retributionist or
            CustomRoles.Sheriff;
    }
    public static bool IsImpostor(this CustomRoles role) // IsImp
    {
        return role is
            CustomRoles.Impostor or
            CustomRoles.Shapeshifter or
            CustomRoles.ShapeshifterTOHE or
            CustomRoles.ImpostorTOHE or
            CustomRoles.EvilDiviner or
            CustomRoles.Wildling or
            CustomRoles.Morphling or
            CustomRoles.BountyHunter or
            CustomRoles.Vampire or
            CustomRoles.Witch or
            CustomRoles.Vindicator or
            CustomRoles.ShapeMaster or
            CustomRoles.Zombie or
            CustomRoles.Warlock or
            CustomRoles.Assassin or
            CustomRoles.Hacker or
            CustomRoles.Miner or
            CustomRoles.Escapee or
            CustomRoles.SerialKiller or
            CustomRoles.Mare or
            CustomRoles.Inhibitor or
            CustomRoles.Councillor or
            CustomRoles.Saboteur or
            CustomRoles.Puppeteer or
            CustomRoles.TimeThief or
            CustomRoles.Trickster or
            CustomRoles.Mafia or
            CustomRoles.Minimalism or
            CustomRoles.FireWorks or
            CustomRoles.Sniper or
            CustomRoles.EvilTracker or
            CustomRoles.EvilGuesser or
            CustomRoles.AntiAdminer or
            CustomRoles.Sans or
            CustomRoles.Bomber or
            CustomRoles.Scavenger or
            CustomRoles.BoobyTrap or
            CustomRoles.Capitalism or
            CustomRoles.Gangster or
            CustomRoles.Cleaner or
            CustomRoles.BallLightning or
            CustomRoles.Greedier or
            CustomRoles.CursedWolf or
            CustomRoles.ImperiusCurse or
            CustomRoles.QuickShooter or
            CustomRoles.Eraser or
            CustomRoles.OverKiller or
            CustomRoles.Hangman or
            CustomRoles.Bard or
            CustomRoles.Swooper or
            CustomRoles.Disperser or
            CustomRoles.Dazzler or
            CustomRoles.Deathpact or
            CustomRoles.Devourer or
            CustomRoles.Camouflager or
            CustomRoles.Twister or
            CustomRoles.Lurker;
    }
    public static bool IsNeutral(this CustomRoles role) // �Ƿ�����
    {
        return role is
            //SoloKombat
            CustomRoles.KB_Normal or
            //Standard
            CustomRoles.Jester or
            CustomRoles.Opportunist or
            CustomRoles.Mario or
            CustomRoles.Medusa or
            CustomRoles.Famine or
            CustomRoles.Baker or
            CustomRoles.HexMaster or
            CustomRoles.Crewpostor or
            CustomRoles.NWitch or
            CustomRoles.Wraith or
            CustomRoles.Vulture or
            CustomRoles.Parasite or
            CustomRoles.Terrorist or
            CustomRoles.Executioner or
            CustomRoles.Juggernaut or
            CustomRoles.Jinx or
            CustomRoles.Lawyer or
            CustomRoles.Arsonist or
            CustomRoles.Sidekick or
            CustomRoles.Jackal or
            CustomRoles.God or
            CustomRoles.Innocent or
            CustomRoles.Pursuer or
        //    CustomRoles.Sidekick or
            CustomRoles.Poisoner or
            CustomRoles.NSerialKiller or
            CustomRoles.Ritualist or
            CustomRoles.Pickpocket or
            CustomRoles.Pelican or
            CustomRoles.Traitor or
            CustomRoles.Revolutionist or
            CustomRoles.FFF or
            CustomRoles.Konan or
            CustomRoles.Gamer or
            CustomRoles.Maverick or
            CustomRoles.CursedSoul or
            CustomRoles.DarkHide or
            CustomRoles.Infectious or
            CustomRoles.Workaholic or
            CustomRoles.Collector or
            CustomRoles.Provocateur or
            CustomRoles.Sunnyboy or
            CustomRoles.Phantom or
            CustomRoles.BloodKnight or
            CustomRoles.Totocalcio or
            CustomRoles.Virus or
            CustomRoles.Succubus or
            CustomRoles.Spiritcaller;
    }

        public static bool IsAbleToBeSidekicked(this CustomRoles role)
    {
        return role is
        CustomRoles.BloodKnight or
        CustomRoles.Virus or
            CustomRoles.Medusa or
        CustomRoles.NSerialKiller or
        CustomRoles.Traitor or
        CustomRoles.HexMaster or
        CustomRoles.Sheriff or
        CustomRoles.Medicaler or
        CustomRoles.Deputy or
        CustomRoles.Ritualist or
        CustomRoles.Pickpocket or
        CustomRoles.Poisoner or
        CustomRoles.Arsonist or
        CustomRoles.Revolutionist or
        CustomRoles.Maverick or
        CustomRoles.NWitch or
        CustomRoles.Succubus or
        CustomRoles.Gamer or
        CustomRoles.DarkHide or
        CustomRoles.Provocateur or
            CustomRoles.Wraith or
            CustomRoles.Juggernaut or
            CustomRoles.Pelican or
            CustomRoles.Infectious or
            CustomRoles.Pursuer or
            CustomRoles.Jinx or
            CustomRoles.Counterfeiter or
            CustomRoles.Totocalcio or
            CustomRoles.Farseer or
            CustomRoles.FFF or
            CustomRoles.SwordsMan or
            CustomRoles.CursedSoul or
            CustomRoles.Monarch or
        CustomRoles.Parasite;
    }

    public static bool IsNeutralWithGuessAccess(this CustomRoles role) // �Ƿ�����
    {
        return role is
            //SoloKombat
            CustomRoles.KB_Normal or
            //Standard
            CustomRoles.Jester or
            CustomRoles.Opportunist or
            CustomRoles.Mario or
            CustomRoles.HexMaster or
            CustomRoles.Crewpostor or
            CustomRoles.NWitch or
            CustomRoles.Wraith or
            CustomRoles.Parasite or
            CustomRoles.Terrorist or
            CustomRoles.Executioner or
            CustomRoles.Medusa or
            CustomRoles.Juggernaut or
            CustomRoles.Vulture or
            CustomRoles.Jinx or
            CustomRoles.Lawyer or
            CustomRoles.Arsonist or
            CustomRoles.Jackal or
            CustomRoles.Sidekick or
            CustomRoles.God or
            CustomRoles.Innocent or
            CustomRoles.Pursuer or
        //    CustomRoles.Sidekick or
            CustomRoles.Poisoner or
            CustomRoles.NSerialKiller or
            CustomRoles.Pelican or
            CustomRoles.Revolutionist or
            CustomRoles.FFF or
            CustomRoles.Traitor or
            CustomRoles.Konan or
            CustomRoles.Gamer or
            CustomRoles.DarkHide or
            CustomRoles.Infectious or
            CustomRoles.Workaholic or
            CustomRoles.Collector or
            CustomRoles.Provocateur or
            CustomRoles.Sunnyboy or
            CustomRoles.Phantom or
            CustomRoles.BloodKnight or
            CustomRoles.Totocalcio or
            CustomRoles.Virus or
            CustomRoles.Succubus or
            CustomRoles.Spiritcaller;
    }
    
    public static bool IsEvilAddons(this CustomRoles role)
    {
        return role is
        CustomRoles.Madmate or
        CustomRoles.Egoist or
        CustomRoles.Charmed or
        CustomRoles.Infected or
        CustomRoles.Contagious or
        CustomRoles.Rogue or
        CustomRoles.Rascal or
        CustomRoles.Soulless;
    }

    public static bool IsMadmate(this CustomRoles role)
    {
        return role is
        CustomRoles.Crewpostor or
        CustomRoles.Parasite;
    }
        public static bool IsTasklessCrewmate(this CustomRoles role)
    {
        return role is
        CustomRoles.Sheriff or
        CustomRoles.Medicaler or
        CustomRoles.Counterfeiter or
        CustomRoles.Monarch or
        CustomRoles.Farseer or
        CustomRoles.SwordsMan or
      //  CustomRoles.Chameleon or
        CustomRoles.Deputy;
    }

    public static bool IsNotKnightable(this CustomRoles role)
    {
        return role is
            CustomRoles.Mayor or
            CustomRoles.Vindicator or
            CustomRoles.Dictator or
            CustomRoles.Knighted or
            CustomRoles.Pickpocket or
            CustomRoles.TicketsStealer;
    }
    public static bool CheckAddonConfilct(CustomRoles role, PlayerControl pc)
    {
        if (!role.IsAdditionRole()) return false;

        if (pc.Is(CustomRoles.GM) || (pc.HasSubRole() && pc.GetCustomSubRoles().Count >= Options.NoLimitAddonsNumMax.GetInt())) return false;
        if (role is CustomRoles.Lighter && (!pc.GetCustomRole().IsCrewmate() || pc.Is(CustomRoles.Bewilder) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Bewilder && (pc.GetCustomRole().IsImpostor() || pc.Is(CustomRoles.Lighter) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Ntr && (pc.Is(CustomRoles.Lovers) || pc.Is(CustomRoles.FFF) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Lovers && pc.Is(CustomRoles.FFF)) return false;
        if (role is CustomRoles.Guesser && ((pc.GetCustomRole().IsCrewmate() && (!Options.CrewCanBeGuesser.GetBool() || pc.Is(CustomRoles.NiceGuesser) || pc.Is(CustomRoles.Judge))) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeGuesser.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeGuesser.GetBool() || pc.Is(CustomRoles.EvilGuesser)) || pc.Is(CustomRoles.Mafia) || pc.Is(CustomRoles.Councillor) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Madmate && !Utils.CanBeMadmate(pc)) return false;
        if (role is CustomRoles.Oblivious && (pc.Is(CustomRoles.Detective) || pc.Is(CustomRoles.Cleaner) || pc.Is(CustomRoles.Medusa) || pc.Is(CustomRoles.Mortician) || pc.Is(CustomRoles.Mediumshiper) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Avanger && pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeAvanger.GetBool() || pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Brakar && pc.Is(CustomRoles.Dictator) || pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Youtuber && (!pc.GetCustomRole().IsCrewmate() || pc.Is(CustomRoles.Madmate) || pc.Is(CustomRoles.Sheriff) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Egoist && (pc.GetCustomRole().IsNeutral() || pc.Is(CustomRoles.Madmate))) return false;
        if (role is CustomRoles.Lazy && (pc.GetCustomRole().IsNeutral() || pc.GetCustomRole().IsImpostor() || pc.GetCustomRole().IsTasklessCrewmate() && !Options.TasklessCrewCanBeLazy.GetBool()) || pc.Is(CustomRoles.Needy) || pc.Is(CustomRoles.Snitch) || pc.Is(CustomRoles.Marshall) || pc.Is(CustomRoles.Transporter) || pc.Is(CustomRoles.Guardian)) return false;
        if (role is CustomRoles.Egoist && pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeEgoist.GetBool()) return false;
        if (role is CustomRoles.Egoist && pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeEgoist.GetBool() || pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.TicketsStealer or CustomRoles.Mimic && !pc.GetCustomRole().IsImpostor()) return false;
        if (role is CustomRoles.TicketsStealer && (pc.Is(CustomRoles.Bomber) || pc.Is(CustomRoles.BoobyTrap) || pc.Is(CustomRoles.Capitalism))) return false;
        if (role is CustomRoles.Mimic && pc.Is(CustomRoles.Mafia)) return false;
        if (role is CustomRoles.Rascal && !pc.GetCustomRole().IsCrewmate()) return false;
        if (role is CustomRoles.Needy && pc.GetCustomRole().IsAdditionRole()) return false;
        if (role is CustomRoles.TicketsStealer && pc.Is(CustomRoles.Vindicator)) return false;
        if (role is CustomRoles.DualPersonality && ((!pc.GetCustomRole().IsImpostor() && !pc.GetCustomRole().IsCrewmate()) || pc.Is(CustomRoles.Madmate))) return false;
        if (role is CustomRoles.DualPersonality && pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeDualPersonality.GetBool()) return false;
        if (role is CustomRoles.DualPersonality && pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeDualPersonality.GetBool() || pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Pessimist && ((!pc.GetCustomRole().IsImpostor() && !pc.GetCustomRole().IsCrewmate()) || pc.Is(CustomRoles.Madmate))) return false;
        if (role is CustomRoles.Pessimist && pc.GetCustomRole().IsImpostor() && !Options.ImpCanBePessimist.GetBool()) return false;
        if (role is CustomRoles.Pessimist && pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBePessimist.GetBool() || pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Seer && ((pc.GetCustomRole().IsCrewmate() && (!Options.CrewCanBeSeer.GetBool() || pc.Is(CustomRoles.Mortician))) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeSeer.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeSeer.GetBool()) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Necroview && pc.Is(CustomRoles.Doctor) || pc.Is(CustomRoles.God) || pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Bait && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeBait.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeBait.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeBait.GetBool()))) return false;
        if (role is CustomRoles.Autopsy && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeAutopsy.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeAutopsy.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeAutopsy.GetBool()))) return false;
        if (role is CustomRoles.Trapper && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeTrapper.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeTrapper.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeTrapper.GetBool()))) return false;
        if (role is CustomRoles.Sidekick && (pc.Is(CustomRoles.Madmate))) return false;
        if (role is CustomRoles.Autopsy && (pc.Is(CustomRoles.Doctor)) || pc.Is(CustomRoles.Tracefinder) || pc.Is(CustomRoles.Scientist)  || pc.Is(CustomRoles.ScientistTOHE)  || pc.Is(CustomRoles.Sunnyboy) ) return false;
        if (role is CustomRoles.Sidekick && pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeSidekick.GetBool()) return false;
        if (role is CustomRoles.Sidekick && pc.GetCustomRole().IsCrewmate() && !Options.CrewmateCanBeSidekick.GetBool()) return false;
        if (role is CustomRoles.Sidekick && pc.GetCustomRole().IsImpostor() && !Options.ImpostorCanBeSidekick.GetBool()) return false;
        if (role is CustomRoles.Madmate && pc.Is(CustomRoles.Sidekick) || pc.Is(CustomRoles.Egoist)) return false;
        if (role is CustomRoles.Sidekick && pc.Is(CustomRoles.Madmate) || pc.Is(CustomRoles.Egoist)) return false;
        if (role is CustomRoles.Egoist && pc.Is(CustomRoles.Sidekick) || pc.Is(CustomRoles.Madmate)) return false;
        if (role is CustomRoles.Sidekick && pc.Is(CustomRoles.Jackal)) return false;
        if (role is CustomRoles.Lucky && pc.Is(CustomRoles.Guardian)) return false;
        if (role is CustomRoles.Bait && pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Bait && pc.Is(CustomRoles.Trapper)) return false;
        if (role is CustomRoles.Trapper && pc.Is(CustomRoles.Bait)) return false;
        if (role is CustomRoles.DualPersonality && pc.Is(CustomRoles.Dictator)) return false;
        if (role is CustomRoles.Trapper && pc.Is(CustomRoles.GuardianAngelTOHE)) return false;
        if (role is CustomRoles.Reach && !pc.CanUseKillButton()) return false;
        if (role is CustomRoles.Watcher && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeWatcher.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeWatcher.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeWatcher.GetBool()))) return false;
        if (role is CustomRoles.Necroview && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeNecroview.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeNecroview.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeNecroview.GetBool()))) return false;
        if (role is CustomRoles.Oblivious && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeOblivious.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeOblivious.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeOblivious.GetBool()))) return false;
        if (role is CustomRoles.Brakar && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeTiebreaker.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeTiebreaker.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeTiebreaker.GetBool()))) return false;
        if (role is CustomRoles.Guesser && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeGuesser.GetBool() && pc.Is(CustomRoles.NiceGuesser)) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeGuesser.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeGuesser.GetBool() && pc.Is(CustomRoles.EvilGuesser)))) return false;
        if (role is CustomRoles.Onbound && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeOnbound.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeOnbound.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeOnbound.GetBool()))) return false;
    //    if (role is CustomRoles.Reflective && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeReflective.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeReflective.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeReflective.GetBool()))) return false;
        if (role is CustomRoles.Unreportable && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeUnreportable.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeUnreportable.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeUnreportable.GetBool()))) return false;
        if (role is CustomRoles.Lucky && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeLucky.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeLucky.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeLucky.GetBool()))) return false;
        if (role is CustomRoles.Rogue && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeRogue.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeRogue.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeRogue.GetBool()))) return false;
        if (role is CustomRoles.Gravestone && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeGravestone.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeGravestone.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeGravestone.GetBool()))) return false;
        if (role is CustomRoles.Flashman && pc.Is(CustomRoles.Swooper)) return false;
        if (role is CustomRoles.Lovers && pc.Is(CustomRoles.Dictator)) return false;
        if (role is CustomRoles.Lovers && pc.Is(CustomRoles.Dictator)) return false;
        if (role is CustomRoles.Bait && pc.Is(CustomRoles.Unreportable)) return false;
    //    if (role is CustomRoles.Onbound && pc.Is(CustomRoles.Reflective)) return false;
    //    if (role is CustomRoles.Reflective && pc.Is(CustomRoles.Onbound)) return false;
        if (role is CustomRoles.Unreportable && pc.Is(CustomRoles.Bait)) return false;
        if (role is CustomRoles.Lovers && pc.Is(CustomRoles.Provocateur)) return false;
        if (role is CustomRoles.Oblivious && pc.Is(CustomRoles.Bloodhound)) return false;
        if (role is CustomRoles.Oblivious && pc.Is(CustomRoles.Vulture)) return false;
        if (role is CustomRoles.Vulture && pc.Is(CustomRoles.Oblivious)) return false;
        if (role is CustomRoles.Brakar && pc.Is(CustomRoles.Dictator)) return false;
        if (role is CustomRoles.Lucky && pc.Is(CustomRoles.Luckey)) return false;
        if (role is CustomRoles.Fool && ((pc.GetCustomRole().IsCrewmate() && !Options.CrewCanBeFool.GetBool()) || (pc.GetCustomRole().IsNeutral() && !Options.NeutralCanBeFool.GetBool()) || (pc.GetCustomRole().IsImpostor() && !Options.ImpCanBeFool.GetBool()) || pc.Is(CustomRoles.SabotageMaster) || pc.Is(CustomRoles.GuardianAngelTOHE))) return false;
        if (role is CustomRoles.Bloodhound && pc.Is(CustomRoles.Oblivious)) return false;
        if (role is CustomRoles.DoubleShot && ((pc.Is(CustomRoleTypes.Impostor) && !Options.ImpCanBeDoubleShot.GetBool()) || (pc.Is(CustomRoleTypes.Crewmate) && !Options.CrewCanBeDoubleShot.GetBool()) || (pc.Is(CustomRoleTypes.Neutral) && !Options.NeutralCanBeDoubleShot.GetBool()))) return false;
        if (role is CustomRoles.DoubleShot && (!pc.Is(CustomRoles.EvilGuesser) && !pc.Is(CustomRoles.NiceGuesser) && !pc.Is(CustomRoles.Guesser) && !Options.GuesserMode.GetBool())) return false;
        if (role is CustomRoles.DoubleShot && Options.ImpCanBeDoubleShot.GetBool() && !pc.Is(CustomRoles.Guesser) && !pc.Is(CustomRoles.EvilGuesser) && (pc.Is(CustomRoleTypes.Impostor) && !Options.ImpostorsCanGuess.GetBool())) return false;
        if (role is CustomRoles.DoubleShot && Options.CrewCanBeDoubleShot.GetBool() && !pc.Is(CustomRoles.Guesser) && !pc.Is(CustomRoles.NiceGuesser) && (pc.Is(CustomRoleTypes.Crewmate) && !Options.CrewmatesCanGuess.GetBool())) return false;
        if (role is CustomRoles.DoubleShot && Options.NeutralCanBeDoubleShot.GetBool() && !pc.Is(CustomRoles.Guesser) && ((pc.GetCustomRole().IsNonNK() && !Options.PassiveNeutralsCanGuess.GetBool()) || (pc.GetCustomRole().IsNK() && !Options.NeutralKillersCanGuess.GetBool()))) return false;
        return true;
    }
    public static RoleTypes GetRoleTypes(this CustomRoles role)
        => GetVNRole(role) switch
        {
            CustomRoles.Impostor => RoleTypes.Impostor,
            CustomRoles.Scientist => RoleTypes.Scientist,
            CustomRoles.Engineer => RoleTypes.Engineer,
            CustomRoles.GuardianAngel => RoleTypes.GuardianAngel,
            CustomRoles.Shapeshifter => RoleTypes.Shapeshifter,
            CustomRoles.Crewmate => RoleTypes.Crewmate,
            _ => role.IsImpostor() ? RoleTypes.Impostor : RoleTypes.Crewmate,
        };
    public static bool IsDesyncRole(this CustomRoles role) => role.GetDYRole() != RoleTypes.GuardianAngel;
    public static bool IsImpostorTeam(this CustomRoles role) => role.IsImpostor() || role == CustomRoles.Madmate;
    public static bool IsCrewmate(this CustomRoles role) => !role.IsImpostor() && !role.IsNeutral() && !role.IsMadmate();

    public static bool IsImpostorTeamV2(this CustomRoles role) => (role.IsImpostorTeam() && role != CustomRoles.Trickster && !role.IsConverted()) || role == CustomRoles.Rascal;
    public static bool IsNeutralTeamV2(this CustomRoles role) => (role.IsConverted() || role.IsNeutral() && role != CustomRoles.Madmate);

    public static bool IsCrewmateTeamV2(this CustomRoles role) => ((!role.IsImpostorTeamV2() && !role.IsNeutralTeamV2()) || (role == CustomRoles.Trickster && !role.IsConverted()));

    public static bool IsConverted(this CustomRoles role)
    {

        return (role is CustomRoles.Charmed ||
                role is CustomRoles.Sidekick ||
                role is CustomRoles.Infected ||
                role is CustomRoles.Contagious ||
                role is CustomRoles.Lovers ||
                ((role is CustomRoles.Egoist) && (ParityCop.ParityCheckEgoistInt() == 1)));
    }
    public static bool IsRevealingRole(this CustomRoles role, PlayerControl target)
    {
        return (((role is CustomRoles.Mayor) && (Options.MayorRevealWhenDoneTasks.GetBool()) && target.AllTasksCompleted()) ||
             ((role is CustomRoles.SuperStar) && (Options.EveryOneKnowSuperStar.GetBool())) ||
            ((role is CustomRoles.Marshall) && target.AllTasksCompleted()) ||
            ((role is CustomRoles.Workaholic) && (Options.WorkaholicVisibleToEveryone.GetBool())) ||
            ((role is CustomRoles.Doctor) && (Options.DoctorVisibleToEveryone.GetBool())) ||
            ((role is CustomRoles.Bait) && (Options.BaitNotification).GetBool()));
    }
    public static bool IsNNK(this CustomRoles role) => role.IsNeutral() && !role.IsNK();
    public static bool IsVanilla(this CustomRoles role)
    {
        return role is
            CustomRoles.Crewmate or
            CustomRoles.Engineer or
            CustomRoles.Scientist or
            CustomRoles.GuardianAngel or
            CustomRoles.Impostor or
            CustomRoles.Shapeshifter;
    }
    public static CustomRoleTypes GetCustomRoleTypes(this CustomRoles role)
    {
        CustomRoleTypes type = CustomRoleTypes.Crewmate;
        if (role.IsImpostor()) type = CustomRoleTypes.Impostor;
        if (role.IsNeutral()) type = CustomRoleTypes.Neutral;
      //  if (role.IsMadmate()) type = CustomRoleTypes.Madmate;
        if (role.IsAdditionRole()) type = CustomRoleTypes.Addon;
        return type;
    }
    public static bool RoleExist(this CustomRoles role, bool countDead = false) => Main.AllPlayerControls.Any(x => x.Is(role) && (x.IsAlive() || countDead));
    public static int GetCount(this CustomRoles role)
    {
        if (role.IsVanilla())
        {
            if (Options.DisableVanillaRoles.GetBool()) return 0;
            var roleOpt = Main.NormalOptions.RoleOptions;
            return role switch
            {
                CustomRoles.Engineer => roleOpt.GetNumPerGame(RoleTypes.Engineer),
                CustomRoles.Scientist => roleOpt.GetNumPerGame(RoleTypes.Scientist),
                CustomRoles.Shapeshifter => roleOpt.GetNumPerGame(RoleTypes.Shapeshifter),
                CustomRoles.GuardianAngel => roleOpt.GetNumPerGame(RoleTypes.GuardianAngel),
                CustomRoles.Crewmate => roleOpt.GetNumPerGame(RoleTypes.Crewmate),
                _ => 0
            };
        }
        else
        {
            return Options.GetRoleCount(role);
        }
    }
    public static int GetMode(this CustomRoles role) => Options.GetRoleSpawnMode(role);
    public static float GetChance(this CustomRoles role)
    {
        if (role.IsVanilla())
        {
            var roleOpt = Main.NormalOptions.RoleOptions;
            return role switch
            {
                CustomRoles.Engineer => roleOpt.GetChancePerGame(RoleTypes.Engineer),
                CustomRoles.Scientist => roleOpt.GetChancePerGame(RoleTypes.Scientist),
                CustomRoles.Shapeshifter => roleOpt.GetChancePerGame(RoleTypes.Shapeshifter),
                CustomRoles.GuardianAngel => roleOpt.GetChancePerGame(RoleTypes.GuardianAngel),
                CustomRoles.Crewmate => roleOpt.GetChancePerGame(RoleTypes.Crewmate),
                _ => 0
            } / 100f;
        }
        else
        {
            return Options.GetRoleChance(role);
        }
    }
    public static bool IsEnable(this CustomRoles role) => role.GetCount() > 0;
    public static CountTypes GetCountTypes(this CustomRoles role)
       => role switch
       {
           CustomRoles.GM => CountTypes.OutOfGame,
           CustomRoles.Jackal => CountTypes.Jackal,
           CustomRoles.Sidekick => CountTypes.Jackal,
           CustomRoles.Poisoner => CountTypes.Poisoner,
           CustomRoles.Pelican => CountTypes.Pelican,
           CustomRoles.Gamer => CountTypes.Gamer,
           CustomRoles.BloodKnight => CountTypes.BloodKnight,
           CustomRoles.Succubus => CountTypes.Succubus,
           CustomRoles.HexMaster => CountTypes.HexMaster,
           CustomRoles.NWitch => CountTypes.NWitch,
           CustomRoles.Wraith => CountTypes.Wraith,
           CustomRoles.Parasite => CountTypes.Impostor,
           CustomRoles.NSerialKiller => CountTypes.NSerialKiller,
           CustomRoles.Juggernaut => CountTypes.Juggernaut,
           CustomRoles.Jinx => CountTypes.Jinx,
           CustomRoles.Infectious => CountTypes.Infectious,
           CustomRoles.Crewpostor => CountTypes.Impostor,
           CustomRoles.Virus => CountTypes.Virus,
           CustomRoles.Ritualist => CountTypes.Ritualist,
           CustomRoles.Pickpocket => CountTypes.Pickpocket,
           CustomRoles.Traitor => CountTypes.Traitor,
           CustomRoles.Medusa => CountTypes.Medusa,
          // CustomRoles.Phantom => CountTypes.OutOfGame,
        //   CustomRoles.CursedSoul => CountTypes.OutOfGame, // if they count as OutOfGame, it prevents them from winning lmao
           
           CustomRoles.Spiritcaller => CountTypes.Spiritcaller,
           _ => role.IsImpostorTeam() ? CountTypes.Impostor : CountTypes.Crew,
       };

    public static bool HasSubRole(this PlayerControl pc) => Main.PlayerStates[pc.PlayerId].SubRoles.Count > 0;
}
public enum CustomRoleTypes
{
    Crewmate,
    Impostor,
    Neutral,
    Addon
}
public enum CountTypes
{
    OutOfGame,
    None,
    Crew,
    Impostor,
    Jackal,
    Pelican,
    Gamer,
    BloodKnight,
    Poisoner,
    Charmed,
    Succubus,
    HexMaster,
    NWitch,
    Wraith,
    NSerialKiller,
    Juggernaut,
    Infectious,
    Virus,
    Rogue,
    DarkHide,
    Jinx,
    Ritualist,
    Pickpocket,
    Traitor,
    Medusa,
    Spiritcaller
}