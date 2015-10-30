#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>

// GPEX HEADERS
#include <gpex.h>

// PRE RUN

void GPEX::getHeader() {
	cout << "\n  ++++++++++++++++++++++++++++++++++++++" << endl;
	cout << " +\t\t\t\t\t+" << endl;
	cout << " +\tsymbla GPEX\t\t\t+" << endl;
	cout << " +\tGet neccessary PHP EXtensions\t+" << endl;
	cout << " +\t\t\t\t\t+" << endl;
	cout << "  ++++++++++++++++++++++++++++++++++++++\n\n" << endl;
}

void GPEX::getMenu(void) {
	cout << " 0 = Programm beenden" << endl;
	cout << " 1 = Pfad zu Quellcode definieren\n" << endl;
	cout << "[Ihre Wahl]: ";
	cin >> gpex_InputUserMenuChoice;
	cin.get();
	if(gpex_InputUserMenuChoice > 1 || gpex_InputUserMenuChoice < 0) {
		cout << "Falsche Eingabe!" << endl;
		getMenu();
	} else {
		switchUserChoice(gpex_InputUserMenuChoice);
	}
}

void GPEX::switchUserChoice(int gpexUCh) {
	switch(gpexUCh) {
		case 0:
		break;
			
		case 1:
			// CLEAR SCREEN
			system("cls");
			// SHOW HEADERS
			getHeader();
			// RUN GPEX
			runGPEX();
		break;
	}
}

// END OF PRE RUN

string GPEX::readFile(string gpex_ReadFilePath) {
	if (gpex_ReadFilePath.find(".php") != string::npos) {
	    cout << "Überprüfe " << gpex_ReadFilePath << "... ";
	    ifstream gpex_PHPFile;
	    gpex_PHPFile.open(gpex_ReadFilePath.c_str());
	    gpex_PHPFile >> gpex_UserPHPFileContent;
	    gpex_PHPFile.close();
	}
	
	return gpex_UserPHPFileContent;
}

void GPEX::runGPEX(void) {
	cout << "[Bitte Pfad angeben]:" << endl;
	cin >> gpex_UserPHPPath;
	cin.get();
	
	gpex_UserPHPFileContent = readFile(gpex_UserPHPPath);
}
