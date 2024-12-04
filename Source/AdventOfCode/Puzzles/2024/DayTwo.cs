namespace AdventOfCode.Puzzles._2024;

public class DayTwo : DailyPuzzle
{
    private const string Data = "27 29 30 33 34 35 37 35\n51 53 54 55 57 60 63 63\n87 90 93 94 98\n41 42 45 47 49 51 53 58\n23 26 23 24 27 28\n32 33 36 37 34 36 39 37\n12 13 11 14 14\n84 87 88 87 91\n54 55 53 56 62\n71 73 74 74 75 76 77\n84 87 90 90 89\n43 46 49 52 55 55 55\n21 23 25 28 30 30 33 37\n20 22 22 24 31\n42 44 45 46 47 51 52 54\n66 67 69 70 74 75 74\n4 6 10 11 14 17 18 18\n50 52 56 59 63\n64 67 68 71 75 77 83\n17 20 22 29 32 33 35\n81 84 89 92 94 92\n11 14 15 17 20 27 27\n20 22 28 30 31 35\n54 55 57 60 67 74\n51 50 51 52 54\n55 53 55 57 59 60 57\n34 33 35 37 39 42 43 43\n23 22 23 26 28 31 34 38\n6 4 7 10 12 13 15 21\n29 27 28 27 30 32 35 36\n83 80 83 85 88 85 87 86\n75 74 76 78 75 75\n51 50 52 54 57 55 56 60\n71 69 72 70 75\n47 46 48 48 50\n64 63 65 65 63\n88 87 88 90 90 91 91\n69 68 68 70 74\n79 77 77 79 86\n8 5 8 12 14 17\n21 19 20 24 26 25\n36 34 38 39 39\n77 75 76 80 84\n64 63 64 68 74\n40 38 43 44 46 48 49\n86 83 84 87 88 91 98 96\n40 37 40 47 50 53 53\n44 41 46 47 51\n7 4 7 9 11 18 24\n55 55 58 59 62 64\n13 13 14 16 13\n61 61 63 66 68 68\n91 91 92 94 98\n9 9 10 11 13 15 18 25\n21 21 23 25 22 25\n92 92 95 93 92\n53 53 56 55 55\n57 57 60 59 60 64\n48 48 45 48 50 56\n5 5 6 6 9\n37 37 38 41 41 44 46 44\n87 87 87 90 90\n51 51 51 54 58\n79 79 79 82 83 86 88 95\n71 71 72 73 77 78\n41 41 43 47 48 50 49\n55 55 59 62 62\n26 26 29 33 35 36 40\n52 52 56 58 65\n16 16 19 24 25\n85 85 86 89 92 93 98 96\n8 8 11 16 16\n87 87 93 94 98\n12 12 15 18 23 24 30\n45 49 50 51 54 55\n51 55 58 60 61 58\n59 63 66 69 70 70\n25 29 32 34 37 40 44\n13 17 19 22 25 28 29 34\n69 73 71 73 74\n3 7 4 5 4\n40 44 47 50 49 52 55 55\n49 53 56 58 57 59 63\n48 52 55 57 60 59 62 68\n60 64 67 67 68 71 74\n4 8 11 13 13 14 17 14\n17 21 22 22 23 26 26\n32 36 36 39 43\n32 36 38 41 41 48\n24 28 32 34 35 36\n13 17 19 23 24 26 27 24\n13 17 20 24 26 26\n8 12 16 18 20 24\n70 74 75 77 81 83 88\n8 12 13 14 16 23 26\n47 51 53 54 59 60 57\n3 7 12 14 16 16\n21 25 30 31 35\n32 36 38 43 50\n40 46 48 50 52 53\n5 10 13 16 19 16\n11 16 18 21 22 23 23\n25 31 33 34 35 36 38 42\n35 41 42 44 51\n83 90 91 92 90 93 95\n84 90 93 92 93 96 98 97\n65 70 67 68 71 73 73\n63 69 70 68 69 73\n57 64 62 65 67 72\n21 26 28 29 31 31 34\n38 44 47 47 45\n77 84 84 86 88 89 89\n67 73 75 75 79\n2 9 12 12 14 15 20\n11 16 19 23 26\n39 45 49 52 49\n74 81 85 86 86\n44 49 51 55 59\n33 40 41 45 52\n48 55 57 64 67 70\n73 80 83 84 87 92 93 91\n36 43 45 47 49 55 55\n50 57 59 61 66 67 71\n31 36 39 40 43 48 54\n60 57 54 52 49 50\n80 78 77 75 74 73 71 71\n61 59 58 55 52 48\n72 70 69 66 64 63 56\n14 11 8 9 8 6\n14 11 9 8 5 2 4 5\n91 89 88 89 86 85 82 82\n11 8 10 7 3\n20 18 20 18 13\n41 39 38 35 35 33 30\n82 81 80 80 83\n54 53 53 52 49 49\n90 88 85 83 83 79\n80 79 79 76 69\n23 22 21 17 16\n60 59 57 55 52 48 51\n43 41 37 35 35\n68 66 63 60 57 53 50 46\n48 45 44 40 35\n54 51 50 49 46 43 37 34\n69 67 64 62 59 56 49 52\n24 21 14 11 10 8 7 7\n52 49 42 41 37\n19 18 17 11 9 2\n64 65 62 59 58 57\n87 90 88 86 88\n56 58 55 53 52 50 49 49\n23 26 25 24 20\n46 47 44 41 34\n22 25 28 27 24\n35 37 35 32 31 33 30 32\n14 15 16 14 12 12\n70 73 71 73 70 69 67 63\n83 85 86 83 78\n68 70 68 66 66 63 60 58\n95 96 95 95 93 94\n19 22 19 18 18 15 15\n14 15 12 12 9 5\n90 93 93 92 90 88 82\n30 32 30 28 25 22 18 17\n81 84 82 78 80\n55 58 55 51 48 45 45\n47 49 46 43 39 36 32\n46 49 48 45 43 42 38 33\n16 17 10 9 7 5 3 2\n11 13 10 5 3 2 1 4\n77 79 76 74 71 68 63 63\n53 56 50 47 46 42\n39 42 35 33 30 27 21\n62 62 60 59 58 56 55\n69 69 68 65 63 66\n87 87 86 84 82 80 78 78\n71 71 68 65 61\n17 17 14 11 10 8 2\n13 13 10 8 10 9 6 3\n39 39 37 40 39 36 33 36\n73 73 71 68 66 63 64 64\n14 14 15 12 10 9 5\n33 33 32 31 32 30 28 21\n78 78 77 77 75 74 72\n86 86 85 85 84 81 82\n3 3 2 2 2\n91 91 88 85 85 82 81 77\n93 93 92 92 89 87 80\n47 47 43 42 41 39\n21 21 18 16 13 11 7 8\n50 50 47 45 44 40 40\n20 20 18 14 11 7\n64 64 63 60 56 55 49\n66 66 65 60 57\n63 63 56 55 54 57\n21 21 15 12 12\n82 82 80 79 74 72 68\n42 42 40 35 30\n59 55 52 49 47 44\n25 21 19 16 17\n57 53 52 51 49 48 48\n59 55 52 51 48 45 41\n28 24 22 21 16\n92 88 86 89 87 86 83 82\n38 34 35 34 32 34\n30 26 29 28 25 22 22\n29 25 24 22 23 20 16\n93 89 88 86 88 86 83 77\n65 61 61 59 58 55\n46 42 39 39 42\n90 86 86 83 80 78 78\n41 37 34 32 31 30 30 26\n21 17 16 16 15 12 6\n55 51 49 45 43\n30 26 23 21 20 16 19\n92 88 87 85 81 81\n42 38 35 31 30 26\n75 71 70 69 68 64 58\n74 70 64 62 60\n34 30 28 21 23\n98 94 93 87 87\n30 26 25 20 19 15\n57 53 50 43 42 40 39 32\n92 86 85 83 80 79 76\n99 94 92 91 89 88 85 87\n27 21 20 18 15 15\n73 67 64 62 61 57\n97 91 90 88 85 83 78\n90 85 82 79 81 79 76 73\n75 68 65 66 65 66\n19 14 11 9 10 7 6 6\n63 56 54 52 49 48 51 47\n72 66 65 63 65 64 62 55\n28 21 19 16 16 13\n72 66 66 63 65\n29 24 24 23 21 21\n70 65 64 64 62 60 57 53\n26 20 18 18 13\n99 94 90 89 86 84 81\n21 14 11 9 5 4 7\n77 71 67 66 64 64\n26 20 18 14 12 11 7\n82 77 76 75 74 70 68 63\n39 34 27 24 21\n20 14 13 8 5 4 1 2\n61 54 53 48 45 45\n22 16 15 8 4\n52 45 42 40 34 29\n91 94 97 96 95 92 90\n55 54 54 56 58 58\n51 51 53 54 56 60 63 61\n36 38 40 45 46 49 48\n86 91 88 91 93 97\n80 76 73 70 66 64 67\n51 48 48 50 53 57\n71 71 69 65 63 63\n93 93 91 92 93\n61 64 63 65 66 70\n67 68 71 74 81 82 84 90\n7 12 14 16 20 22 24 21\n5 3 4 6 9 10 10 17\n65 66 65 65 61\n56 59 60 64 65 69\n68 69 68 71 74 77\n93 96 94 93 89 91\n8 7 8 9 12 11 15\n80 73 75 74 71\n75 71 69 66 64 58 57 58\n23 21 20 23 21 16\n53 56 54 51 51 54\n72 77 83 85 88 89 91\n55 51 49 46 46 43 42\n17 13 9 6 3 3\n30 26 20 17 15 12 9 9\n67 67 74 75 76 78\n90 88 85 84 81 77 75 74\n7 7 14 16 20\n62 66 73 75 73\n11 13 16 17 18 19 26\n34 27 25 28 26 23 20 15\n20 18 21 23 26 29 33 37\n6 11 9 12 14 15 12\n71 73 72 69 66\n51 54 53 52 52 45\n81 88 85 88 88\n16 12 11 10 9 9\n69 69 66 63 59 56 52\n80 84 86 93 93\n30 24 22 15 13 12 9\n99 99 94 93 92 94\n61 58 57 56 56 52\n85 89 87 89 92 97\n57 54 54 52 46\n45 40 37 34 32 29 27 30\n66 64 58 56 55 52 52\n37 44 45 50 53 54 51\n76 70 68 65 65 64 61 61\n69 69 67 65 66 63 66\n15 19 22 26 28 30 34\n7 7 8 9 11 14 18 22\n11 15 17 17 23\n70 64 63 62 60 60 57 50\n27 27 30 32 38 40 41 47\n42 40 36 35 34 32 26\n23 22 24 26 26 28 31 34\n53 57 57 60 61 64 66 70\n57 57 60 61 64 67 68 71\n61 61 58 57 52 49 49\n45 43 41 39 32 26\n79 83 85 88 89 92 94 94\n7 7 9 8 11 11\n79 79 78 76 78\n37 35 36 39 41 42 44 44\n78 78 79 77 81\n52 55 54 51 50 43\n80 82 85 88 90 87 88 88\n88 84 84 82 79 76 72\n35 41 43 45 47 48 55 59\n59 59 60 59 57 57\n45 45 47 46 43 40 36\n50 44 40 39 36 34 32 28\n57 61 60 62 64 65 67\n75 71 69 66 68 66 61\n71 67 66 65 63 65 64\n34 29 28 26 24 22 25 27\n32 32 29 29 29\n45 52 53 55 55\n60 57 58 62 65 63\n22 16 15 13 12 9 7 3\n39 43 44 47 50 53 56 57\n38 42 44 46 43\n53 50 52 59 58\n22 21 17 15 14 11 11\n61 68 69 68 71 74 79\n85 83 83 81 81\n52 56 58 65 69\n82 76 70 67 65 63 56\n57 64 67 70 73 73 74 81\n10 10 10 8 6 4\n63 65 63 62 58 55 55\n49 48 47 46 43 42 41\n44 46 47 50 52 55 58\n16 18 21 24 26\n35 36 38 41 42 45 48\n79 77 76 73 70 69 67\n20 17 16 14 11\n48 46 43 40 37\n55 58 61 62 65 67\n89 88 87 84 83 80 78\n69 71 73 75 76\n31 28 25 24 22 21 18 15\n34 31 29 27 25 22 20 17\n58 55 52 49 47 44 41\n24 25 27 29 31 33 36 38\n92 90 89 87 85 83\n9 12 15 18 20\n78 77 75 74 71 68\n20 17 16 13 12 9 7\n18 15 12 10 8\n85 82 81 78 77 75\n77 78 79 81 83\n84 85 86 87 89 90 92 94\n57 56 53 52 51 48 47 46\n46 49 52 54 55 57 58\n40 37 34 33 32 31\n47 50 52 53 55\n50 48 47 45 43 40\n63 61 59 58 57 55 52\n23 21 18 15 13 11\n67 64 61 59 57 55\n54 52 51 50 49 47\n37 40 43 46 47 48 49\n11 10 9 7 4 3 2\n79 80 83 86 87 88\n55 54 53 52 49 48\n18 16 13 10 7\n73 72 70 69 68 67 66 65\n40 38 36 35 33 31 29 28\n44 45 47 49 51\n70 73 75 78 79 80 81 84\n21 23 26 29 31 34 35\n1 3 5 8 10 11 13\n39 40 41 42 43 45 46\n72 75 77 78 80 82\n42 43 45 47 49 52\n22 19 18 16 13 11\n43 45 47 49 50 52 54\n68 66 64 63 60 57 56\n53 55 57 59 62 65\n30 27 26 23 22\n30 32 35 37 38 40\n27 24 23 21 20 18 17 14\n38 39 40 43 44 45 47 49\n2 5 7 8 11\n94 91 90 87 85 84 83 82\n70 68 66 63 61 58\n49 52 55 56 59 60\n32 31 29 27 25 24 23 20\n51 50 49 48 46 43 40 39\n19 20 21 23 24\n86 84 82 79 77 75\n30 28 26 23 21 20 18\n93 92 89 86 84 83 80 78\n42 44 46 49 52 54 57\n33 34 37 39 42\n76 78 81 82 85 86 87 90\n97 96 93 90 89 87 85\n87 90 91 94 97 99\n37 34 33 31 29\n45 42 39 37 35 34\n37 40 41 44 45 46 49\n4 6 7 8 10 11 14 17\n89 87 85 84 81 79 77\n74 75 76 79 82 84 85 86\n97 96 93 91 90 87 84 81\n91 92 93 96 98\n13 12 11 9 6 5\n37 38 39 42 43 45\n26 25 24 21 20\n40 41 42 43 45 46 47 49\n38 36 33 31 30 29 27\n84 81 80 79 77 75 72\n84 82 81 80 79\n47 49 52 53 55 58 59 62\n71 72 74 75 76 78 80\n56 53 51 49 46 44 42\n67 66 65 64 63 62 59\n64 67 68 71 72 73 74\n54 56 57 60 63 64 65\n97 96 94 92 90 87 85 84\n31 28 25 24 23\n90 87 84 82 81 80 79 77\n87 89 92 94 96\n84 83 82 79 77 74 71\n56 59 61 63 64 67\n66 68 69 72 75 78 81\n56 59 60 61 64\n85 86 88 91 93 94 97\n82 81 80 77 76\n1 3 4 5 7 9 12 13\n89 87 84 81 78\n89 87 86 85 84 81 78 76\n79 81 82 83 84\n34 33 31 28 27\n24 23 22 20 18 16 14 12\n32 31 30 28 25 23 20\n63 61 58 57 56 53 50 47\n42 43 45 46 47 49 50\n46 47 48 49 50 53 55\n18 15 13 10 7\n11 12 13 14 16 18 19\n64 66 67 69 72 75 76\n31 30 27 26 25 23 20 17\n76 74 72 69 68 66 64 61\n23 21 19 18 15 13 11 10\n30 29 28 26 25 22 20 18\n10 11 13 15 17 18 21\n4 5 7 10 12 14 17\n71 70 68 67 64\n89 86 85 84 83 81 80\n86 83 82 81 78 75\n53 55 56 59 62\n29 30 33 36 39 42 45 47\n14 17 19 20 21 23 26\n69 71 72 73 75 76\n84 81 80 79 78\n11 8 6 4 3 1\n76 77 78 81 82 85 86 87\n85 88 91 92 93 94 96\n57 58 59 61 63\n43 42 41 40 37\n21 19 17 14 13 10 9 6\n19 18 15 14 11 9 8\n18 15 13 11 10\n45 48 50 51 54 57\n51 48 45 44 41 40\n48 47 45 44 42 40 37 35\n58 55 52 50 48 45\n65 68 69 72 73 74 75\n52 55 56 58 59 62 63 64\n29 30 32 35 36 39\n70 72 73 76 78\n85 86 87 88 90\n20 23 25 28 29 30\n11 10 7 6 4\n84 81 78 77 75\n85 82 81 80 78 77\n82 79 77 76 73 71 69 67\n23 21 19 18 15 14 11\n83 80 79 76 75 73\n4 7 8 10 11\n26 24 21 20 17 15 14 12\n86 85 83 81 79 77\n75 74 73 70 68 66 63\n32 31 30 28 26\n67 64 63 62 59\n50 51 54 56 57 58 60 63\n63 60 59 58 56 55 54\n71 69 66 65 64 62 61 59\n50 47 45 43 42 39\n25 26 28 30 32 33 34\n55 56 59 60 61\n3 6 9 11 12 13 16\n85 82 79 76 75 73 72 70\n75 76 79 81 84\n67 68 71 73 75 76 78\n77 75 73 70 68\n47 45 42 41 40 39 36\n60 57 56 54 52 51 49 46\n56 54 52 51 48 45 44\n45 44 43 42 39\n75 77 80 83 86 89 92\n64 65 66 67 70 71\n35 33 31 29 28 26\n41 42 44 47 50 52 54 55\n13 11 10 9 7 5 3\n11 14 15 17 20 21 23 25\n61 63 66 69 71 74\n79 78 75 74 72 71 69\n85 83 81 78 76\n81 79 78 76 73\n74 77 79 81 83\n10 11 12 13 16 18 19\n64 61 60 57 54 51\n70 68 65 63 60 58 55\n78 79 81 83 85 88 90\n13 15 18 20 22 25 28\n71 68 67 66 63\n56 58 61 62 65\n67 65 64 62 59 57 54\n44 41 39 38 37\n48 45 44 42 40 37 36 33\n55 58 59 60 62\n50 47 45 43 40 38 37 35\n61 64 66 67 68 71 72 75\n36 38 40 41 44 45\n52 54 57 59 60\n61 62 64 65 66 68\n84 85 87 90 92 94 96 97\n29 30 32 34 35 36 37 38\n73 71 68 66 63 61 60 58\n52 49 47 44 43 41\n91 89 87 84 83 81 78 76\n76 74 73 71 68 65 62 61\n79 77 74 72 71 69 68 65\n35 34 32 29 27\n22 21 19 17 16 14\n34 32 30 29 27 24\n87 89 90 92 93 94\n30 31 32 35 38\n25 22 21 20 19 18\n40 43 45 48 51 52\n69 70 72 75 77\n38 40 41 42 45 48 50 52\n79 82 83 86 87\n48 47 46 44 43 42 40\n65 63 61 60 57 54\n13 16 18 21 23 24 25 26\n40 41 43 44 47 50 51\n45 42 41 40 38\n8 6 5 3 2 1\n81 80 78 75 73\n85 84 83 82 79 76 75 74\n38 40 42 44 45 48\n7 8 9 11 12\n49 50 51 52 53\n63 60 57 56 54 53 51\n19 21 24 27 30\n49 46 44 41 38\n57 60 63 64 66 68 71\n28 30 31 34 35 37\n65 62 59 57 55 54\n88 85 82 80 78 77 75\n80 81 84 86 88 91\n42 43 46 47 50 52 55\n47 46 45 44 43 41\n83 86 89 90 92 95\n43 46 48 49 50 51\n48 45 42 41 39\n87 90 92 94 95\n39 40 42 45 47 49 50\n44 41 39 36 33 32 31 29\n32 31 30 27 25 23 20 19\n39 37 34 31 29\n51 52 53 54 55 58 59\n52 50 49 47 45\n49 51 54 55 57 60 62 64\n29 28 25 23 21 20 18 17\n38 37 34 31 28 26 25\n79 76 74 72 71 69\n36 38 40 42 43 45 47 50\n86 83 80 78 77 74\n33 35 37 38 41 42\n28 31 34 35 37 39 42 43\n32 34 37 40 42 44 46 47\n57 60 62 63 65 66 68\n83 85 88 89 90\n44 47 50 53 55 56 59 60\n33 31 29 27 24 23 21 18\n28 25 24 22 20 17 15 14\n33 32 30 28 27\n72 69 68 65 64\n13 16 19 20 22 25\n31 29 28 27 24 21\n69 68 65 63 62 59 57\n45 48 51 52 55 57 59 60\n13 14 15 16 17 20 22 25\n43 41 38 37 35 33 31\n73 72 69 68 65 62 59\n75 77 79 82 85 88\n10 13 16 18 19 21\n74 71 70 67 66 64 62\n54 53 52 51 49\n94 93 90 88 87 85 83\n39 41 42 44 47 48 50\n1 4 5 7 9 10\n71 70 67 66 63 61\n14 15 16 17 19 20 22\n5 6 7 9 12 14 15\n67 64 62 60 57 56 55\n24 25 27 30 33 35\n35 36 38 40 41\n67 64 61 58 56 55 54\n73 72 71 70 69 68\n96 93 92 89 87 85 82 81\n80 81 83 86 88\n12 9 6 5 2\n92 91 88 85 82 80\n92 91 88 86 85 83 82 79\n73 74 77 80 81 82\n75 76 77 80 82 83 84\n12 9 6 5 4\n80 83 85 87 89 92 95 96\n21 24 25 28 31 34\n51 49 46 43 42\n7 6 3 2 1\n35 36 38 40 41 43 44\n92 91 90 89 86 85\n51 50 47 44 41\n70 71 74 75 78 79\n21 24 26 28 30 31 33\n33 36 37 40 41 42 44\n68 66 63 62 59 56 54\n51 52 54 57 60 62 64\n70 73 76 78 81 84 85\n65 68 70 73 76 77\n3 5 7 8 9 11 13 14\n28 26 23 20 18 15\n39 36 33 32 29 27\n22 24 26 28 30\n54 51 48 46 43\n36 34 31 30 28 26 25 23\n69 71 73 76 79\n28 31 34 36 39 42 45\n24 23 22 21 19 16 14\n99 97 95 94 93 91 88 86\n65 62 61 60 58 56 54 53\n17 19 20 22 25 28 31 32\n5 7 8 9 10 13 14\n26 23 21 20 17\n49 52 54 55 56\n34 37 40 42 44 45 48 50\n11 14 17 18 19 20 22 24\n17 14 13 12 9 8 6\n81 79 78 76 74 73 72\n71 69 66 65 64 61 59\n77 80 81 84 85\n5 8 10 11 14 17\n27 24 23 22 19 17\n68 67 64 62 59 56\n23 25 28 29 30 32\n92 89 88 86 83 82\n62 64 65 68 69 72\n25 23 21 18 16\n69 70 71 74 77 79\n72 71 69 66 64 62\n10 8 5 4 3 1\n35 38 41 43 46 47 49 50\n83 82 79 77 75 72\n41 38 35 34 31 28 27 24\n60 61 63 66 68 69 72 74\n54 57 59 61 62 63 66 67\n78 81 82 85 86 89 92 95\n16 13 10 9 8 6 4\n65 67 69 70 73\n48 50 53 56 58 59 61\n12 9 6 4 3\n8 9 12 13 14 15 17 18\n14 16 19 22 23\n42 39 36 35 32 29 28 27\n17 14 11 9 8 7 4 2\n60 58 57 55 53\n43 41 40 39 36 33\n48 47 46 43 40\n26 23 22 19 18 16 14 11\n41 40 37 35 33 30 27 25\n40 43 44 46 47 48 50 51\n53 56 59 61 62 64 67 68\n39 42 43 44 47 50 53 56\n7 10 11 12 14\n49 47 45 43 41 39 36 33\n76 74 73 70 67\n49 51 54 57 58 60 62\n44 42 39 37 34\n57 54 52 50 48 45 43\n71 69 68 65 64 62\n77 76 73 71 68 67\n9 11 14 17 18\n29 31 34 36 38 41 43 45\n3 6 9 12 13 16\n94 92 91 89 88 87\n8 10 13 16 18\n13 16 17 18 20 22 24 25\n56 58 59 60 62 64\n52 55 58 60 61\n69 70 73 76 77 80 82 83\n66 64 63 60 59\n84 86 88 89 92 94 95 98\n32 31 28 25 23\n23 24 26 27 30 32\n90 89 88 86 83\n77 80 83 85 87 90 91 94\n69 68 66 65 63 61 59 58\n17 19 22 24 27\n37 35 32 29 27 25 22 21\n25 27 29 32 35 36 38\n62 60 58 56 54\n6 9 11 12 15 17 20\n80 83 84 86 87\n89 91 94 95 97 98 99\n20 23 25 28 31 32 34\n86 88 90 91 93\n70 67 64 61 59 58 56 55\n17 20 22 24 25\n18 20 21 23 24 25 28 31\n98 95 93 92 89 86\n46 45 42 41 38 36\n10 12 14 15 17 20\n24 21 18 17 15 14 13\n8 10 13 14 17 20\n90 91 93 95 98 99\n39 38 36 33 31\n52 49 46 45 44 41 39 36\n64 62 60 59 58 56 53 52\n64 63 62 61 58 57 56\n90 88 86 84 82\n21 24 26 29 30\n92 89 87 86 85 83 81 78\n85 83 80 77 76 75 72\n29 32 35 37 40 42 45\n7 9 10 13 15 17 18 19\n24 27 28 29 32 33\n59 58 55 53 50\n93 90 87 85 83 80 78 77\n19 16 14 13 11 8\n99 96 93 92 89 87\n7 8 10 12 15\n21 24 27 28 29 30 32\n37 39 40 41 43\n43 42 41 38 37\n72 71 70 69 66 64 62\n30 31 32 35 38 39 42\n13 15 16 19 20 21\n21 18 16 15 13\n22 25 26 27 29 31 34 37\n41 39 36 35 32\n50 47 46 44 42 39 38 36\n79 76 74 72 71 70 67 65\n29 30 33 36 38 41 42\n73 74 76 78 80 83 85 86\n51 50 49 48 46 43\n80 79 77 74 73 70 68 66\n88 87 85 82 80 78 77\n45 46 47 50 51 54 56 57\n4 6 8 9 10 13\n1 3 6 9 12 15 18 19\n37 40 43 45 47 50\n78 79 80 83 86\n61 63 64 65 66 69 71\n22 25 28 31 34 37\n24 26 27 29 32\n91 88 87 84 83 81\n78 81 82 83 84 86 89 92\n17 18 20 23 26\n34 31 29 26 23 22 19\n20 19 16 15 13 10\n32 33 36 39 42 43 46 48\n78 79 82 83 84 86 87 89\n67 69 72 73 75 78 81 84\n62 59 56 53 50\n91 90 87 85 82\n51 53 54 55 58 61 63\n67 66 64 62 61 60 57\n80 77 74 72 69 67 64 61\n59 62 64 65 67 70 71 72\n45 43 40 38 37 35 32 29\n85 82 80 78 77 76 74 72\n71 69 66 64 61 59\n7 9 11 12 14\n73 70 69 66 63 62 61\n75 78 81 84 86\n51 50 49 46 44 41 38\n97 94 93 91 89 87 84\n8 5 3 2 1\n21 19 18 17 15\n96 95 94 92 90 87\n56 58 59 62 65 67\n49 52 53 55 56\n43 42 40 37 36 33\n57 59 60 61 63 66 68\n59 62 63 66 67\n75 72 70 67 65 64\n73 70 69 67 64 62 59\n77 74 73 72 69 67 64\n46 47 49 51 53\n30 31 32 35 36\n23 25 28 30 32 34\n82 84 86 89 90 92\n75 73 72 71 68 67 66\n64 62 61 58 55\n97 96 93 90 89 87 86\n20 21 23 24 27\n59 58 57 56 54\n64 63 60 58 57 55 53 52\n74 72 69 67 64 62 60\n23 26 29 30 33\n30 31 33 34 37 40\n87 86 83 81 79 76\n53 55 57 59 61\n26 28 31 32 34 36 37 38\n36 35 34 31 29 26\n19 16 14 11 8 5\n41 40 38 36 34 33 32 30\n55 58 60 63 64 65 66\n52 51 50 48 46 43 41\n41 38 36 33 30\n83 80 79 76 74 71 68\n45 44 42 41 38 36 33\n21 20 18 17 14 11 10\n3 6 8 11 13 14 17 18\n81 78 75 73 70 68 67\n15 16 19 21 24 27 29 32\n78 79 82 85 86\n35 37 38 40 42\n72 71 68 66 65 62\n73 72 70 68 67 64\n40 43 45 46 49 52 53\n76 75 74 71 69 66\n68 70 71 72 75\n45 43 40 37 35 33 30 29\n8 9 11 13 14\n78 75 73 71 69 67 65 62\n40 37 34 32 30 27\n79 77 74 71 69\n74 75 76 77 78 79 81 84\n44 41 38 36 33 31 28 25\n78 75 72 70 69\n79 82 83 86 87 90 91 94\n35 32 30 28 25 22\n96 95 93 90 88 85\n85 88 90 92 93 95 97\n58 55 54 51 49\n22 19 18 15 12 9 7 4\n92 90 87 86 83 82 81\n86 85 84 83 81 79 78\n67 65 63 62 61\n80 79 76 74 71 70\n14 17 20 21 22 24 27 28\n97 95 92 89 87\n23 26 27 30 32 33 35\n58 57 55 52 50 47\n67 70 72 75 76 78 81\n10 12 13 16 18 20 23 24\n65 66 67 70 72\n10 7 5 4 2\n35 34 32 31 30 27 25\n38 40 43 44 46 47\n77 80 81 83 84 87 89 92\n80 77 76 75 74\n30 31 34 35 38 41 42\n86 87 88 91 93\n77 75 74 71 70 68 66 63\n25 26 29 32 34 37\n33 31 30 29 28 27 26\n15 17 20 23 26 28 30\n86 83 81 78 75 73 72 70\n73 70 67 66 65 63\n19 18 17 16 13 11 9 8\n35 38 39 41 42 45\n24 22 20 19 16 15\n5 6 9 11 13 14\n31 34 37 40 41 44\n75 76 78 80 81\n52 49 47 45 42 41 38 35\n80 77 74 72 69 68 67 65\n50 47 46 43 40 38 36 35\n50 49 46 43 40\n83 82 79 76 75 74\n82 85 88 89 91\n22 24 27 28 31 32 33\n95 92 90 89 86\n19 21 22 25 28 29 31\n15 17 18 19 21 23\n75 78 79 80 82\n80 78 75 74 72 71\n51 49 47 46 43 42 41\n55 56 59 60 63 64 66 67\n67 66 65 63 61 58 56\n42 43 45 48 50 51\n29 32 35 36 37\n5 8 9 12 13 14 17\n81 84 85 86 87 88 90\n59 60 63 65 68 71\n43 41 38 35 33 30\n29 31 33 34 36 39 42 43\n72 69 66 63 62 60\n13 12 10 7 6 5 3 1\n48 50 53 55 57 60\n39 41 42 43 45\n80 78 75 72 69 67 64 62\n82 80 79 76 75 73 71\n46 43 40 39 38\n55 52 51 49 48\n81 78 75 72 71 70 69 68\n38 37 35 33 30 29\n36 38 39 42 44 46 49\n73 72 70 68 66 64\n10 9 6 5 4 2\n7 10 13 16 17 18\n74 72 69 67 65 62 61 58\n44 47 48 50 52 54 56\n75 77 80 82 84 85 88\n14 16 18 20 23 24\n65 62 61 58 56 54 52\n22 19 17 14 13 10 7 6\n53 50 48 46 43 41\n10 12 14 17 20\n24 21 20 18 17 14 12\n66 65 63 62 60 58\n84 83 81 79 76 73\n37 38 41 43 46 47 50\n88 86 85 82 80 78\n5 6 9 10 12\n64 62 61 58 55 53 52\n29 30 33 36 39 42 45\n89 90 91 92 94 96\n41 39 37 35 32 31 29 28\n83 85 86 89 92 95 96 99\n84 86 88 90 91 94 95 98\n77 79 82 84 87 89 91\n19 21 22 23 25 26 28\n20 23 25 28 31 34\n84 81 78 75 73 70 67 66\n11 8 6 4 3\n64 63 61 59 56\n88 89 92 94 95 97 98 99\n87 84 83 80 77\n66 68 69 70 71 72 75\n19 22 24 27 30\n31 33 35 38 40 43\n60 63 64 65 66 69 71\n70 73 75 77 79 80 82\n21 20 19 16 15 14 12\n33 30 29 28 27 24 23 20\n30 31 33 35 36 38\n19 17 14 12 11\n76 77 79 80 83 84\n29 30 33 36 39 40 42\n24 21 18 17 16 13 10\n32 34 35 38 39 41 42 43\n11 10 7 6 4 2 1\n2 3 6 9 10\n58 55 53 51 50 47 44\n49 46 43 40 37 35\n56 57 59 61 62\n80 82 85 88 91 93 94 95\n89 86 85 82 79 76 75\n57 55 52 49 46 43 42 39\n40 41 44 45 46 48\n12 9 6 3 2\n74 76 78 81 84 85 86 88\n89 91 92 93 94 97\n76 74 72 71 69 68\n42 43 44 47 48 50 53\n42 43 44 47 48\n86 88 90 92 95\n15 18 20 22 24\n74 71 69 68 65 62 61 59\n5 8 10 12 13 16\n8 10 13 14 17\n32 29 28 26 24 22 19 18\n99 96 95 92 89 87\n48 49 50 51 54\n38 39 41 44 47 48\n82 84 85 88 89 91\n39 41 42 43 46\n83 80 79 77 74 73 72\n85 84 82 79 76 75\n49 48 45 43 40 38 36\n9 12 15 18 20 22 25 27";

    public override int Year => 2024;
    public override int Day => 2;

    public override void Solve()
    {
        var reports = GetParsedData();

        SolvePartOne(reports);
        SolvePartTwo(reports);
    }

    private static void SolvePartOne(List<List<int>> reports)
    {
        var safeReports = reports.Where(IsSafeAccordingToPartOne).ToList().Count;

        Console.WriteLine("Day 2, Part One: " + safeReports);
    }

    private static void SolvePartTwo(List<List<int>> reports)
    {
        var safeReports = reports.Where(IsSafeAccordingToPartTwo).ToList().Count;

        Console.WriteLine("Day 2, Part Two: " + safeReports);
    }

    private static bool IsSafeAccordingToPartOne(List<int> input)
    {
        bool? increasing = null;

        for (var index = 1; index < input.Count; index++)
        {
            var currentLevel = input[index];
            var previousLevel = input[index - 1];

            var isIncreasing = currentLevel > previousLevel;

            if (index == 1) increasing = isIncreasing;

            var difference = isIncreasing
                ? currentLevel - previousLevel
                : previousLevel - currentLevel;

            if (difference < 1 || difference > 3) return false;
            if (isIncreasing != increasing) return false;
        }

        return true;
    }

    private static bool IsSafeAccordingToPartTwo(List<int> input)
    {
        var isSafeByDefault = IsSafeAccordingToPartOne(input);

        if (isSafeByDefault)
        {
            return true;
        }

        for (var index = 0; index < input.Count; index++)
        {
            var newInput = new List<int>(input);

            newInput.RemoveAt(index);

            var isSafe = IsSafeAccordingToPartOne(newInput);

            if (isSafe) return true;
        }

        return false;
    }

    private static List<List<int>> GetParsedData()
    {
        var lines = Data.Split("\n");

        var reports = new List<List<int>>();

        foreach (var line in lines)
        {
            var levels = line
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            reports.Add(levels);
        }

        return reports;
    }
}