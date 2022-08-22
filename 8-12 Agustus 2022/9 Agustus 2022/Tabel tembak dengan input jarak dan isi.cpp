#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

vector<int> isian0 = { 100, 150, 200, 250, 300, 350, 400, 450 };
vector<int> derajat0 = { 10, 15, 20, 25, 30, 35, 40, 45 };

vector<int> isian1 = { 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800 };
vector<int> derajat1 = { 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };

vector<int> isian2 = { 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 
                1050, 1100, 1150, 1200, 1250, 1300, 1350 };
vector<int> derajat2 = { 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 
                105, 110, 115, 120, 125, 130, 135 };
				               
vector<int> isian3 = { 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 
                2000, 2100, 2200, 2300, 2400, 2500, 2600 };
vector<int> derajat3 = { 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 
                200, 210, 220, 230, 240, 250, 260 };
				                
vector<int> isian4 = { 1900, 2000, 2100, 2200, 2300, 2400, 2500, 2600, 2700, 2800, 2900, 3000, 3100, 
                3200, 3300, 3400, 3500, 3600, 3700 };
vector<int> derajat4 = { 190, 200, 210, 220, 230, 240, 250, 260, 270, 280, 290, 300, 310, 
                320, 330, 340, 350, 360, 370 };
				                
vector<int> isian5 = { 2400, 2500, 2600, 2700, 2800, 2900, 3000, 3100, 3200, 3300, 3400, 3500, 3600, 
                3700, 3800, 3900, 4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700 };
vector<int> derajat5 = { 240, 250, 260, 270, 280, 290, 300, 310, 320, 330, 340, 350, 360, 
                370, 380, 390, 400, 410, 420, 430, 440, 450, 460, 470 };
                
vector<int> isian6 = { 3500, 3600, 3700, 3800, 3900, 4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 
                4800, 4900, 5000, 5100, 5200, 5300, 5400, 5500, 5600 };
vector<int> derajat6 = { 350, 360, 370, 380, 390, 400, 410, 420, 430, 440, 450, 460, 470, 
                480, 490, 500, 510, 520, 530, 540, 550, 560 };
                
vector<int> isian7 = { 3900, 4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800, 4900, 5000, 
                5100, 5200, 5300, 5400, 5500, 5600, 5700, 5800, 5900, 6000, 6100, 6200, 6300 };
vector<int> derajat7 = { 390, 400, 410, 420, 430, 440, 450, 460, 470, 480, 490, 500, 
                510, 520, 530, 540, 550, 560, 570, 580, 590, 600, 610, 620, 630 };
                
vector<int> isian8 = { 4500, 4600, 4700, 4800, 4900, 5000, 5100, 5200, 5300, 5400, 5500, 5600, 5700, 
                5800, 5900, 6000, 6100, 6200, 6300, 6400, 6500 };
vector<int> derajat8 = { 450, 460, 470, 480, 490, 500, 510, 520, 530, 540, 550, 560, 570, 
                580, 590, 600, 610, 620, 630, 640, 650 };

int main() {
    int a, c, d, e;
    char b;

    while (true) {

        cout << "berapa isian mortar: ";
        cin >> a;
        

        if (a == 0) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian0.begin(), isian0.end(), e);
            d = result - isian0.begin();
            if (result != end(isian0)){
            	cout << "sudut tembak: "<< derajat0[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 1) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian1.begin(), isian1.end(), e);
            d = result - isian1.begin();
            if (result != end(isian1)){
            	cout << "sudut tembak: "<< derajat1[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 2) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian2.begin(), isian2.end(), e);
            d = result - isian2.begin();
            if (result != end(isian2)){
            	cout << "sudut tembak: "<< derajat2[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 3) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian3.begin(), isian3.end(), e);
            d = result - isian3.begin();
            if (result != end(isian3)){
            	cout << "sudut tembak: "<< derajat3[d] << endl;    			
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 4) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian4.begin(), isian4.end(), e);
            d = result - isian4.begin();
            if (result != end(isian4)){
            	cout << "sudut tembak: "<< derajat4[d] << endl;	
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 5) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian5.begin(), isian5.end(), e);
            d = result - isian5.begin();
            if (result != end(isian5)){
            	cout << "sudut tembak: "<< derajat5[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 6) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian6.begin(), isian6.end(), e);
            d = result - isian6.begin();
            if (result != end(isian6)){
            	cout << "sudut tembak: "<< derajat6[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 7) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian7.begin(), isian7.end(), e);
            d = result - isian7.begin();
            if (result != end(isian7)){
            	cout << "sudut tembak: "<< derajat7[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else if (a == 8) {
        	cout << "berapa jarak target: ";
        	cin >> e;
            auto result = find(isian8.begin(), isian8.end(), e);
            d = result - isian8.begin();
            if (result != end(isian8)){
            	cout << "sudut tembak: "<< derajat8[d] << endl;
      		}
      		else{
      			cout << "Jarak tidak terjangkau" << endl;
			  }
        }
        else {
            cout << "tidak ada isian " << a << endl;
        }

        cout << "membidik lagi?(y/n) ";
        cin >> b;

        if (b == 'n') {
            break;
        }
    }
}
