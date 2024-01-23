// Server.h ①
// Server 동작에 관련된 함수 모두를 정의해놓은 헤더파일
#ifndef GOMOKU_SERVER_H
#define GOMOKU_SERVER_H
#define _CRT_SECURE_NO_WARNINGS
#pragma comment (lib, "ws2_32.lib")
#include <iostream>
#include <Winsock.h>
#include <vector>
#include "Util.h"
#include "Client.h"

using namespace std;

// Server.h ②
static class Server {
private:
	static SOCKET serverSocket;
	static WSAData wsaData;
	static SOCKADDR_IN serverAddress;
	static int nextID;
	static vector<Client*> connections;
	static Util util;
public:
	static void start();
	static int clientCountInRoom(int roomID);
	static void playClient(int roomID);
	static void exitClient(int roomID);
	static void putClient(int roomID, int x, int y);
	static void fullClient(Client* client);
	static void enterClient(Client* client);
	static void ServerThread(Client* client);
};
#endif

