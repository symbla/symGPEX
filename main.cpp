/*
	(c) 2015 symbla.org
	Alle Rechte vorbehalten.
*/

#include <iostream>
#include <string>
#include <windows.h>

// GPEX HEADER
#include <gpex.h>
#include <config.h>

using namespace std;

int main(int argc, char *argv[]) {	
	Config config;
	config.gpex_Version = "0.1";
	config.gpex_ExtListPath = ".\\components\\gpexcomponents.xml";

	GPEX gpex;
	gpex.getHeader();
	gpex.getMenu();
	
	system("pause");
	return 0;
}
