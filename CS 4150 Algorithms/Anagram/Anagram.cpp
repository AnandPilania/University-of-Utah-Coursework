#include "pch.h"
#include <iostream>
#include <string>
#include <unordered_set>
#include <map>
#include <algorithm>
#include <vector>
#include <chrono>

std::map<std::string, int> map;
std::map<std::string, int> rejected;
std::vector<std::string> words;
int total;
int letters;

bool checkForAnagrams(std::string, int);
void addToHash(std::string, int);
bool checkRejected(std::string);


	int main(int argc, char** argv)
	{
		auto start = std::chrono::high_resolution_clock::now();

		std::cin >> total >> letters;
	std::string str;
	while (std::getline(std::cin, str, '\n')) {
		if(!str.empty())
		words.push_back(str);
	}

		for (int i = 0; i < words.size(); i++) {

			if (checkForAnagrams(words[i], i)) {
			}
			else if(!checkRejected(words[i])){
				addToHash(words[i], i);
			}
		}

	
		std::cout << map.size();

		auto stop = std::chrono::high_resolution_clock::now();

		auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(stop - start);

		std::cout << "time: " + duration.count();
	}

	bool checkForAnagrams(std::string str, int index) {
		std::sort(str.begin(), str.end());
		if (map.find(str) != map.end()) {
			map.erase(str);
			rejected.emplace(str, index);
			return true;
		}
		return false;
	}

	 void addToHash(std::string str, int index) {
		 std::sort(str.begin(), str.end());
		 map.emplace(str, index);
	}

	 bool checkRejected(std::string str) {
		 std::sort(str.begin(), str.end());
		 if (rejected.find(str) != rejected.end()) {
			 return true;
		 }
		 return false;
	 }

