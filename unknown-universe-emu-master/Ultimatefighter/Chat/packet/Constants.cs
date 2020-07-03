﻿namespace NettyBaseReloaded.Chat.packet
{
    public class Constants
    {
        public const string PARAM_SEPERATOR="@";

        public const string ATRIBUTE_SEPERATOR="|";

        public const string OBJECT_SEPERATOR="}";

        public const string LINE_SEPERATOR="#";

        public const string CMD_USER_MSG="a";

        public const string CMD_ADMIN_NOT_EXIST="b";

        public const string CMD_ADMIN_LOGIN_OK="c";

        public const string CMD_GET_ADMIN_ROOMLIST="d";

        public const string CMD_SET_ADMIN_ROOMLIST="e";

        public const string CMD_GET_ITEMLIST="f";

        public const string CMD_SET_ITEMLIST="g";

        public const string CMD_MOD_JOIN_ROOM="h";

        public const string CMD_MOD_JOIN_OK="i";

        public const string CMD_ADMIN_MSG="j";

        public const string CMD_SET_MOD_CHATCOLOR="k";

        public const string CMD_ADMIN_LOGIN="l";

        public const string CMD_USER_EXIT="n";

        public const string CMD_NEW_ITEM="o";

        public const string CMD_ITEM_EXIST="p";

        public const string CMD_ITEM_NOTFOUND="q";

        public const string CMD_UPDATE_ITEM="r";

        public const string CMD_DELETE_ITEM="s";

        public const string CMD_WRONG_PASSWORD="t";

        public const string CMD_NEW_BADWORD="u";

        public const string CMD_BADWORD_EXIST="v";

        public const string CMD_DELETE_BADWORD="w";

        public const string CMD_UPDATE_BADWORD="x";

        public const string CMD_NEW_ACCOUNT="y";

        public const string CMD_PASSWORD_CHANGE_FAILED="z";

        public const string CMD_ACCOUNT_EXIST="aa";

        public const string CMD_NO_VALID_STRING="ab";

        public const string ERROR_LONGNAME_TO_LONG="ac";

        public const string ERROR_LONGNAME_TO_SHORT="ad";

        public const string ERROR_SHORTNAME_TO_LONG="ae";

        public const string ERROR_SHORTNAME_TO_SHORT="af";

        public const string CMD_GET_LOG="ag";

        public const string CMD_SET_LOG="ah";

        public const string CMD_NO_LOG_FOUND="ai";

        public const string CMD_GET_LOG_UPDATE="aj";

        public const string CMD_SET_LOG_UPDATE="ak";

        public const string CMD_GET_BANNED_USER_ITEMS="al";

        public const string CMD_SET_BANNED_USER_ITEMS="am";

        public const string CMD_BANNLIST_RESULT_LIMIT="an";

        public const string CMD_NO_BANNED_USER_ITEMS="ao";

        public const string CMD_UPDATE_LOGIN_LOGOUT="ar";

        public const string CMD_KICK_USER="as";

        public const string CMD_BANN_USER="at";

        public const string CMD_USER_KICKED="au";

        public const string WRONG_USERID="av";

        public const string USER_ALREADY_BANNED="aw";

        public const string CMD_USER_BANNED="ax";

        public const string CMD_CHANGE_PASSWORD="ay";

        public const string CMD_UPDATE_ACCOUNT="az";

        public const string CMD_PASSWORD_CHANGED="ba";

        public const string CMD_REMOVE_BANNED_USER="bb";

        public const string CMD_DEBANN_USER="bc";

        public const string CMD_GET_BANN_LOG="bd";

        public const string CMD_SET_BANN_LOG="be";

        public const string CMD_WORD_EXIST="bf";

        public const string CMD_GET_BANN_LOG_UPDATE="bg";

        public const string CMD_SET_BANN_LOG_UPDATE="bh";

        public const string CMD_ADD_ROOM_ID="bi";

        public const string CMD_REMOVE_ROOM_ID="bj";

        public const string CMD_GET_USERLIST="bk";

        public const string CMD_SET_USERLIST="bl";

        public const string CMD_CLEAR_USERLIST="bm";

        public const string CMD_CREATE_PROJECT="bn";

        public const string CMD_UPDATE_PROJECT="bo";

        public const string CMD_DELETE_PROJECT="bp";

        public const string CMD_PROJECT_EXIST="bq";

        public const string CMD_UPDATE_ADMIN_ITEM="br";

        public const string CMD_UPDATE_ADMIN_LEVEL_ID="bs";

        public const string CMD_SETTINGS_SAVED="bt";

        public const string CMD_USER_LOGIN="bu";

        public const string CMD_USER_LOGIN_OK="bv";

        public const string CMD_WRONG_CHAT_VERSION="bw";

        public const string CMD_GET_USER_ROOMLIST="bx";

        public const string CMD_SET_USER_ROOMLIST="by";

        public const string CMD_USER_JOIN="bz";

        public const string CMD_USER_ENTER_ROOM="ca";

        public const string CMD_USER_KICKED_BY_SYSTEM="cb";

        public const string CMD_USER_BANNED_BY_SYSTEM="cc";

        public const string CMD_KICK_BY_SYSTEM="cd";

        public const string CMD_BANN_BY_SYSTEM="ce";

        public const string CMD_NO_MORE_PRIVATE_ROOMS_ALLOWED="cf";

        public const string CMD_CREATE_ROOM_WRONG_ARGUMENTS="cg";

        public const string CMD_ROOMNAME_TOO_SHORT="ch";

        public const string CMD_PRIVATE_ROOM_EXIST="ci";

        public const string CMD_PRIVATE_ROOM_CREATED="cj";

        public const string CMD_ROOM_DELETED="ck";

        public const string CMD_PRIVATE_ROOM_NOT_EXIST="cl";

        public const string CMD_WRONG_COMMAND="cm";

        public const string CMD_CANNOT_INVITE_YOURSELF="cn";

        public const string CMD_INVITE_ERROR_NOT_YOUR_ROOM="co";

        public const string CMD_INVITE_ERROR_USER_NOT_FOUND="cp";

        public const string CMD_SHOW_INVITE_MESSAGE="cq";

        public const string CMD_YOU_INVITED="cr";

        public const string CMD_NO_WHISPER_MESSAGE="cs";

        public const string CMD_USER_NOT_EXIST="ct";

        public const string CMD_CANNOT_WHISPER_YOURSELF="cu";

        public const string CMD_USER_WHISPERS="cv";

        public const string CMD_YOU_WHISPER="cw";

        public const string CMD_LEAVE_ROOM="cx";

        public const string CMD_LEAVE_ROOM_OK="cy";

        public const string CMD_DELETE_ACCOUNT="cz";

        public const string CMD_FLOOD_WARNING="da";

        public const string CMD_SHOW_BANN_MESSAGE="db";

        public const string CMD_UPDATE_ONLINE_STATUS="dc";

        public const string CMD_ADMIN_ENTER_ROOM="dd";

        public const string CMD_ADMIN_LEAVE_ROOM="de";

        public const string CMD_SHOW_USERS="df";

        public const string CMD_SHOW_MODERATORS="dg";

        public const string CMD_LOGOUT_MODERATOR="dh";

        public const string CMD_LOGOUT_MODERATOR_OK="di";

        public const string CMD_GET_SERVER_STATISTICS="dj";

        public const string CMD_SET_SERVER_STATISTICS="dk";

        public const string CMD_CREATE_ROOM="dl";

        public const string CMD_INVALID_ROOM_NAME="dm";

        public const string CMD_COMPANY_ID_NOT_AVAILABLE="dn";

        public const string CMD_ROOM_CREATED="do";

        public const string CMD_DELETE_ROOM="dp";

        public const string CMD_DEVELOPER_MSG="dq";

        public const string CMD_ADD_FAVORITE_ROOM_ID="dr";

        public const string CMD_REMOVE_FAVORITE_ROOM_ID="ds";

        public const string CMD_COPY_INSTANCE="dt";

        public const string CMD_NEW_TEXTMODULE="du";

        public const string CMD_DELETE_TEXTMODULE="dv";

        public const string CMD_TEXTMODULE_CREATED="dw";

        public const string CMD_TEXTMODULE_DELETED="dx";

        public const string CMD_DELETE_PRIVATE_ROOM="dy";

        public const string CMD_CANNOT_LEAVE_ROOM="dz";

        public const string CMD_USER_JOIN_INVITED_ROOM="ea";

        public const string CMD_USER_LEFT_INVITED_ROOM="eb";

        public const string CMD_NOT_ROOM_OWNER="ec";

        public const string CMD_ROOMNAME_TOO_LONG="ed";

        public const string CMD_SET_OFFLINE_BANN_LOG="ee";

        public const string CMD_GET_USER_LOG="ef";

        public const string CMD_SET_USER_LOG="eg";

        public const string CMD_GET_MISSING_USER="eh";

        public const string CMD_SET_MISSING_USER="ei";

        public const string CMD_USER_LOGIN_NOK="ej";

        public const string CMD_PING="ek";

        public const string CMD_PONG="el";

        public const string CMD_HACK_ATTACK_DETECTED="em";

        public const string MSG_SEPERATOR="%";

        public const string CMD_GET_ACCOUNT_INFORMATION="eo";

        public const string CMD_SET_ACCOUNT_INFORMATION="ep";

        public const string CMD_PRIVATE_MOD_MSG="eq";

        public const string CMD_END_PRIVATE_MOD_SESSION="er";

        public const string CMD_GET_FILTERED_LOG="es";

        public const string CMD_SET_FILTERED_LOG="et";

        public const string CMD_SET_IP_BANNS="eu";

        public const string CMD_DEBANN_IP="ev";

        public const string CMD_REMOVE_BANNED_IP="ew";

        public const string CMD_AUTH_FAILED="ex";

        public const string CMD_IP_FAILED="ey";

        public const string CMD_CHAT_MINIMIZED="ez";

        public const string CMD_CHAT_MAXIMIZED="fa";

        public const string CMD_UPDATE_WORD_TO_GAME_ITEMS="fb";

        public const string CREATE_GROUP_ROOM="fc";

        public const string CMD_GROUP_ROOM_CREATED="fd";

        public const string CMD_REMOVE_GROUP_ROOM="fe";

        public const string CMD_LEAVE_GROUP_ROOM="ff";

        public const string CMD_GET_GAMEHELP="fg";

        public const string CMD_SET_GAMEHELP="fh";

        public const string CMD_UPDATE_GAMEHELPITEMS="fi";

        public const string CMD_SET_GAMEHELPITEM_STATUS="fj";

        public const string CMD_SCHEDULED_MSG="fk";

        public const string CMD_SHOW_RESTART_WINDOW="en";

        public const string CMD_USER_REMOVED_FROM_DYN_ROOM="fr";

        public const string CMD_USER_JOINED_DYN_ROOM="fs";

        public const string CMD_USER_LEFT_DYN_ROOM="ft";

        public const string CMD_SCAL_JOINED_CHILD="fu";

        public const string CMD_CREATE_PRIVATE_ROOM_WITH_USERS="fv";

        public const string CMD_DYN_ROOM_CREATED="fy";

        public const string CMD_SECTOR_ROOM_UPDATE="fz";

        public const string CMD_DYN_ROOM_REMOVED="ga";

        public const string CMD_ROOM_NAME_NOT_ALLOWED="gb";

        public const string CMD_CREATE_CLAN_ROOM="gw";

        public const string CMD_CREATE_CLAN_ROOM_CREATED="gx";

        public const string CMD_USER_ADDED_TO_DYN_ROOM="fq";
    }
}