#ifndef GPEX_H
#define GPEX_H

#include <iostream>
#include <string>

using namespace std;

class GPEX
{
	public:
		// VARIABLEN
		int gpex_InputUserMenuChoice;
		string gpex_UserPHPPath;
		string gpex_UserPHPFileContent;
		
		// METHODEN
			// PRE RUN
			void getHeader();
			void getMenu(void);
			void switchUserChoice(int);
		
		string readFile(string);
		void runGPEX(void);
};

#endif
