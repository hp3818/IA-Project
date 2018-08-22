using UnityEngine;
using Prototype.NetworkLobby;
using System.Collections;
using UnityEngine.Networking;

public class NetworkLobbyHook : LobbyHook 
{
    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
    {
        LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();
        SetUpLocalPlayer localPlayer = gamePlayer.GetComponent<SetUpLocalPlayer>();

        localPlayer.pname = lobby.name;
        localPlayer.playerColor = lobby.playerColor;
    }
}
