#include <iostream>
#include <algorithm>
using namespace std;

int isian0[8] = { 100, 150, 200, 250, 300, 350, 400, 450 };
int isian1[13] = { 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800 };
int isian2[22] = { 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200, 1250, 1300, 1350 };
int isian3[21] = { 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000, 2100, 2200, 2300, 2400, 2500, 2600 };
int isian4[19] = { 1900, 2000, 2100, 2200, 2300, 2400, 2500, 2600, 2700, 2800, 2900, 3000, 3100, 3200, 3300, 3400, 3500, 3600, 3700 };
int isian5[24] = { 2400, 2500, 2600, 2700, 2800, 2900, 3000, 3100, 3200, 3300, 3400, 3500, 3600, 3700, 3800, 3900, 4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700 };
int isian6[22] = { 3500, 3600, 3700, 3800, 3900, 4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800, 4900, 5000, 5100, 5200, 5300, 5400, 5500, 5600 };
int isian7[25] = { 3900, 4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800, 4900, 5000, 5100, 5200, 5300, 5400, 5500, 5600, 5700, 5800, 5900, 6000, 6100, 6200, 6300 };
int isian8[21] = { 4500, 4600, 4700, 4800, 4900, 5000, 5100, 5200, 5300, 5400, 5500, 5600, 5700, 5800, 5900, 6000, 6100, 6200, 6300, 6400, 6500 };

int main(){
	int a;
	char b;

while (true){

    cout << "berapa jarak  target: ";
    cin >> a;

	if (bool exists = find(begin(isian0), end(isian0), a) != end(isian0)) {
        cout << "Isian 0" << endl;
    }
    else if (bool exists = find(begin(isian1), end(isian1), a) != end(isian1)) {
        cout << "Isian 1" << endl;
    }
    else if (bool exists = find(begin(isian2), end(isian2), a) != end(isian2)) {
        cout << "Isian 2" << endl;
    }
    else if (bool exists = find(begin(isian3), end(isian3), a) != end(isian3)) {
        cout << "Isian 3" << endl;
    }
    else if (bool exists = find(begin(isian4), end(isian4), a) != end(isian4)) {
        cout << "Isian 4" << endl;
    }
    else if (bool exists = find(begin(isian5), end(isian5), a) != end(isian5)) {
        cout << "Isian 5" << endl;
    }
    else if (bool exists = find(begin(isian6), end(isian6), a) != end(isian6)) {
        cout << "Isian 6" << endl;
    }
    else if (bool exists = find(begin(isian7), end(isian7), a) != end(isian7)) {
        cout << "Isian 7" << endl;
    }
    else if (bool exists = find(begin(isian8), end(isian8), a) != end(isian8)) {
        cout << "Isian 8" << endl;   
    }
    else {
        cout << "jarak tidak terjangkau" << endl;
    }
    
	cout << "membidik lagi?(y/n) ";
    cin >> b;

	if (b == 'n'){
    break;
}
}
}
