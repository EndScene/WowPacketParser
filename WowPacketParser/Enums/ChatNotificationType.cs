namespace PacketParser.Enums
{
    public enum ChatNotificationType
    {
        Joined = 0x00,
        Left = 0x01,
        YouJoined = 0x02,
        YouLeft = 0x03,
        WrongPassword = 0x04,
        NotMember = 0x05,
        NotModerator = 0x06,
        PasswordChanged = 0x07,
        OwnerChanged = 0x08,
        PlayerNotFound = 0x09,
        NotOwner = 0x0A,
        ChannelOwner = 0x0B,
        ModeChange = 0x0C,
        AnnouncementsOn = 0x0D,
        AnnouncementsOff = 0x0E,
        ModerationOn = 0x0F,
        ModerationOff = 0x10,
        Muted = 0x11,
        PlayerKicked = 0x12,
        Banned = 0x13,
        PlayerBanned = 0x14,
        PlayerUnbanned = 0x15,
        PlayerNotBanned = 0x16,
        PlayerAlreadyMember = 0x17,
        Invite = 0x18,
        InviteWrongFaction = 0x19,
        WrongFaction = 0x1A,
        InvalidName = 0x1B,
        NotModerated = 0x1C,
        PlayerInvited = 0x1D,
        PlayerInviteBanned = 0x1E,
        Throttled = 0x1F,
        NotInArea = 0x20,
        NotInLfg = 0x21,
        VoiceOn = 0x22,
        VoiceOff = 0x23,
        Unknown1 = 0x24
    }
}
