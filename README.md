# Mayın Tarlası Oyunu / Minesweeper Game

### Geliştirici / Developed by Abdullah Akkaya  
**Yazılım Mühendisliği, Kocaeli Üniversitesi / Software Engineering, Kocaeli University**  
**Kocaeli/Türkiye / Kocaeli/Turkey**  
**E-posta / Email:** abdullahakkayaa@icloud.com

---

## Genel Bakış / Overview
Bu depo, Windows Forms kullanılarak C# ile geliştirilen Mayın Tarlası oyununu içermektedir. Oyun, oyuncuların bir ızgarada gizli mayınları tespit etmeye çalıştığı stratejik bir bulmaca oyunudur. Kullanıcı dostu arayüzü ve farklı zorluk seviyeleri ile keyifli bir deneyim sunar. Oyunun sonunda oyuncular skorlarını diğer oyuncularla karşılaştırabilir.

This repository contains the Minesweeper game developed in C# using Windows Forms. The game is a strategic puzzle game where players must detect hidden mines on a grid while avoiding detonating them. With a user-friendly interface and multiple difficulty levels, the application provides an engaging and enjoyable experience for players. Players can also compare their scores with others via a leaderboard displayed at the end of each game.

---

## Özellikler / Features
- **Grafiksel Kullanıcı Arayüzü (GUI) / Graphical User Interface (GUI):**
  - Kullanıcı girdisine göre dinamik ızgara oluşturma. / Dynamic grid generation based on user input.
  - Sol tıklama ile hücre açma, sağ tıklama ile mayın işaretleme. / Intuitive controls with left-click to reveal cells and right-click to flag potential mines.
- **Özelleştirilebilir Oyun / Customizable Gameplay:**
  - Oyuncular, ızgara boyutunu (10x10 - 30x30) belirleyebilir. / Players can input their desired grid size (10x10 to 30x30).
  - Mayın sayısını belirleyebilir (minimum 10, maksimum `(ızgara boyutu - 1)^2`). / Specify the number of mines (minimum of 10, up to `(grid size - 1)^2`).
- **Otomatik Hücre Açma / Automatic Cell Reveal:**
  - Komşu mayın içermeyen hücreleri otomatik açma. / Opens surrounding cells automatically if no adjacent mines are detected.
- **Oyun Bitiş Senaryoları / Endgame Scenarios:**
  - Tüm mayınsız hücreleri açan oyuncu kazanır. / Players win by revealing all non-mine cells.
  - Mayına tıklayan oyuncu kaybeder ve tüm mayınlar açılır. / If a mine is clicked, all mines are revealed, and the game ends.
- **Skor Tablosu / Scoreboard:**
  - En yüksek 10 skoru takip eder ve görüntüler. / Tracks and displays the top 10 scores.
  - Skorlar, geçen süre ve doğru işaretlenen mayınlara göre hesaplanır. / Scores are calculated based on time taken and correctly flagged mines.

---

## Nasıl Oynanır? / How to Play
1. **Giriş Parametreleri / Input Parameters:**
   - İsminizi, ızgara boyutunu ve mayın sayısını girin. / Enter your name, grid size, and the number of mines.
2. **Hücre Açma / Reveal Cells:**
   - Sol tıklama ile hücre açın. / Left-click on a cell to reveal it.
   - Sayılar, komşu mayın sayısını gösterir. / Numbers indicate how many adjacent mines are present.
3. **Mayın İşaretleme / Flag Mines:**
   - Sağ tıklama ile mayın olduğunu düşündüğünüz hücreyi işaretleyin. / Right-click to flag a cell if you suspect it contains a mine.
4. **Kazanma Koşulu / Win Condition:**
   - Tüm mayınsız hücreleri açın. / Successfully reveal all non-mine cells.
5. **Kaybetme Koşulu / Lose Condition:**
   - Mayına tıklarsanız oyunu kaybedersiniz. / Click on a mine.

---

## Teknik Detaylar / Technical Details
### Programlama Dili / Programming Language:
- **C#** kullanılarak geliştirildi. / Developed in **C#**.

### Sınıf Yapısı / Class Structure:
- **Form1:** Oyun arayüzü. / Main interface for game setup and play.
- **Form2:** Skor tablosunu görüntüleme. / Displays the leaderboard.
- **Oyun Sınıfı / Game Class:** Oyunun mantığını kontrol eder. / Handles game logic and mechanics.
- **Skor Tablosu Sınıfı / Scoreboard Class:** Kullanıcı skorlarını yönetir. / Manages user scores and leaderboard.

### Ana Metotlar / Key Methods:
- `GenerateGrid()`: Izgara oluşturur. / Dynamically creates the grid.
- `PlaceMines()`: Mayınları yerleştirir. / Randomly places mines.
- `RevealCell()`: Hücre açma mantığını işler. / Handles the logic for revealing a cell.
- `CheckWinCondition()`: Oyunun kazanılıp kazanılmadığını kontrol eder. / Verifies if the game is won.
- `ShowMines()`: Oyun bittiğinde tüm mayınları gösterir. / Reveals all mines when the game ends.

---

## Kurulum ve Çalıştırma / Installation and Setup
1. **Depoyu Klonlayın / Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/minesweeper-game.git
   ```
2. **Projeyi Açın / Open the Project:**
   - Çözüm dosyasını (`.sln`) Visual Studio ile açın. / Open the solution file (`.sln`) in Visual Studio.
3. **Çalıştırın / Run the Application:**
   - Derleyin ve çalıştırın. / Build and run the project directly from Visual Studio.

---

## Katkıda Bulunma / Contribution
Katkıda bulunmak için:
To contribute:
1. Depoyu çatallayın (fork).
2. Yeni bir dal oluşturun. / Create a new branch.
3. Değişikliklerinizi kaydedin. / Commit your changes.
4. Değişiklikleri iterek bir çekme isteği oluşturun. / Push and open a pull request.

---

## Lisans / License
Bu proje MIT Lisansı ile lisanslanmıştır. / This project is licensed under the MIT License.

---

## Ekran Görüntüleri / Screenshots

<img width="372" alt="Screenshot 2025-01-17 at 15 25 44" src="https://github.com/user-attachments/assets/f943e13c-6e9f-4fa2-ba9d-c9b8ecaec289" />
<img width="372" alt="Screenshot 2025-01-17 at 15 26 24" src="https://github.com/user-attachments/assets/d06288dc-e96c-4987-ac43-bd889221e7b6" />
<img width="504" alt="Screenshot 2025-01-17 at 15 26 54" src="https://github.com/user-attachments/assets/6d7e7ac0-898a-4c7c-82fd-0c8f4a74bc18" />
<img width="374" alt="Screenshot 2025-01-17 at 15 28 57" src="https://github.com/user-attachments/assets/c5502269-c5ba-4026-b309-7aa5522dcb2d" />
<img width="504" alt="Screenshot 2025-01-17 at 15 27 09" src="https://github.com/user-attachments/assets/b2f93129-6b17-42d4-8d26-f96c8523cd3f" />
