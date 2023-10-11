#include <iostream>
#include <random>
using std::rand, std::cout, std::endl;

class Gladiator {
    private:
        int hp = 100;
        int min_dmg = 1;
        int max_dmg = 100;
        int armor = 0;
    
    public:
        Gladiator(int h, int min_d, int max_d, int a);

        void checkout(Gladiator g1, Gladiator g2) {
            if (g1.hp < 0 && g2.hp > 0) {
                cout << "The second Gladiator wins the fight!";
            }
            else if (g1.hp > 0 && g2.hp < 0) {
                cout << "The first Gladiator wins the fight!";
            }
            else if(g1.hp < 0 && g2.hp < 0) {
                cout << "Wow, that's a tie... They killed eachother...";
            }
        }

        void hit_player(Gladiator g1, Gladiator g2) {
            int g1_dmg, g2_dmg;
            g1_dmg = g1.min_dmg + (rand() % g1.max_dmg);
            g2_dmg = g2.min_dmg + (rand() % g2.max_dmg);
            g1.hp = g1.hp - (g2_dmg - g1.armor*2);
            g2.hp = g2.hp - (g1_dmg - g2.armor*2);
            cout << "Gladiator 1 took " << g2_dmg - g1.armor*2 << ". HP left: " << g1.hp << endl;
            cout << "Gladiator 2 took " << g1_dmg - g2.armor*2 << ". HP left: " << g2.hp << endl;
            checkout (g1, g2);
        };   

        int get_hp (Gladiator g) {
            return g.hp;
        }
};

int main() {
    Gladiator G1(100, 15, 25, 2);
    Gladiator G2(80, 5, 30, 5);

    while (G1.get_hp(G1) > 0 && G2.get_hp(G2) > 0) {
        G1.hit_player(G1,G2);
        G2.hit_player(G2,G1);
    }
}