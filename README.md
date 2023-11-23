# CaddyWiperCS
C# implementation of the CaddyWiper wiper malware using [CISA's](https://www.cisa.gov/news-events/analysis-reports/ar22-115c) breakdown of the associated IOCs.

## How to use
CaddyWiperCS comes in two states - `int armed = 0` (default) and `int armed = 1`. This changes the way the malware operates, between a more subdued version of the malware that only wipes one targeted file and the full capability of the CaddyWiper class of malware.

### Operational Events
This malware falls under [T1485: Data Destruction](https://attack.mitre.org/techniques/T1485/) and operates as follows:
  1. Grabs a list of the files for all users found in `C:\Users\`.
  2. Attempts to re-write the content of each file as a series of NULL bytes, matching the size of the original file to maintain the same filesize but erase the contents
  3. Attempt to access attached drives starting with `D:\`

## Arming the malware
  1. Change `int armed = 0` to `1` on line # of [Program.cs](/CaddyClone/Program.cs)
