// Util.h
#ifndef GOMOKU_UTIL_H
#define GOMOKU_UTIL_H
using namespace std;
#include <vector>
#include <sstream>

class Util {
public:
	// 문자열: Hello World YUJIN. 
	// 구분자: ' '
	// Hello, World, YUJIN
	vector<string> getTokens(string input, char delimiter);
};
#endif
