#ARK RAPID - Utility Libraries
---

# 🔧 ARK-RAPID Utility Library

A lightweight and intuitive .NET utility library that simplifies everyday development tasks — from **string checks**, **date formatting**, and **epoch conversions** to **file handling with safe operations**.

🚀 Designed to save time and reduce boilerplate code, so you can focus on building features instead of rewriting helpers.

---

## 📦 Installation

Install via NuGet package manager:

```powershell
dotnet add package ark.net.util
```

Or via Visual Studio Package Manager Console:

```powershell
Install-Package ark.net.util
```

---

## ✨ Features

### 1. **String Extensions**

* Check if a string is `null`, empty, or whitespace with a single call.

```csharp
using ark.net.util;

string? text = null;

if (text.AnyNull())  
{
    Console.WriteLine("String is null, empty, or whitespace");
}
```

---

### 2. **Date Utilities**

Convenient stamps and epoch conversions for filenames, logs, and time operations.

```csharp
using ark.net.util;

// Current year, month, day stamps
Console.WriteLine(DateUtil.CurrentYearStamp());       // "2025"
Console.WriteLine(DateUtil.CurrentMonthStamp());      // "2025_09"
Console.WriteLine(DateUtil.CurrentDateStamp());       // "2025_09_22"

// Full timestamp with millisecond precision
Console.WriteLine(DateUtil.CurrentTimeStamp());       // "2025_09_22_14_35_12_123456"

// Epoch conversions
double epoch = DateUtil.CurrentEpochTime();
Console.WriteLine(epoch);                             // 1758500112 (seconds since 1970)

DateTime? utcTime = DateUtil.EpochToDateTime(epoch);
Console.WriteLine(utcTime);                           // "9/22/2025 09:35:12"

// Convert epoch to specific timezone
DateTime? indiaTime = DateUtil.EpochToIndiaDateTime(epoch);
Console.WriteLine(indiaTime);                         // "9/22/2025 15:05:12"
```

---

### 3. **File Utilities**

Safer file operations — prevent overwrites, sanitize names, and auto-create directories.

```csharp
using ark.net.util;

// Save text safely (auto-creates directory, appends _1, _2 if file exists)
string path = FileUtil.Save(@"C:\Logs\app_log.txt", "Hello World!");
Console.WriteLine(path); // "C:\Logs\app_log.txt" or "C:\Logs\app_log_1.txt"

// Save binary
byte[] data = { 0x1, 0x2, 0x3 };
string binPath = FileUtil.Save(@"C:\Data\file.bin", data);

// Sanitize filenames
string dirty = "inv@lid:fi*le?.txt";
Console.WriteLine(FileUtil.SanitizeFileName(dirty));  // "inv_lid_fi_le_.txt"

// Append to filename
string newFile = FileUtil.AppendToFileName(@"C:\Data\report.csv", "2025");
Console.WriteLine(newFile); // "C:\Data\report_2025.csv"

// Export to CSV from dynamic records
var records = new[]
{
    new { Id = 1, Name = "Alice" },
    new { Id = 2, Name = "Bob" }
};
byte[] csv = FileUtil.ExportToCsv(records);
File.WriteAllBytes(@"C:\Exports\data.csv", csv);
```

---

## 📘 Intuitive Understanding for Developers

* **ExtnUtil** → Think of it as shorthand for common `null/empty` checks.
* **DateUtil** → Like a "timestamp Swiss Army knife" — year, month, day, epoch, timezone conversions.
* **FileUtil** → Makes file handling **bulletproof** — no overwrites, no missing directories, always clean filenames.

---

## ✅ Best Practices

* Use `DateUtil.CurrentTimeStamp()` for **unique filenames**.
* Use `FileUtil.Save()` when you want to **avoid accidental overwrites**.
* Always sanitize user-input filenames with `FileUtil.SanitizeFileName()`.

---

## 📄 License

MIT License. Free to use in personal and commercial projects.

---

Do you want me to also add **badges** (NuGet version, downloads, build status) at the top for a more professional touch?
