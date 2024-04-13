# Generating input data
Generates data, required for Profiler to work.
### Usage:
`python3 generate.py maxNums [ random ]`

### Arguments:
- `maxNums` - Maximal amount of generated numbers.
- `random`
    - If `random` argument is present, each generated number will be random in interval `<0; maxNums>`
    - If `random` argument is not present, each generated number will be from interval `<1; maxNums>`

### Examples:
- `python3 generate.py 5`
    - Generates files `data5.txt` containing input for the `Profiler`and `data5_ref` containing input for online calculators of the standard deviaton such as [this one](https://www.hackmath.net/cz/kalkulacka/vypocet-smerodatne-odchylky).
    - File contains numbers from in range `<1; 5>`

- `python3 generate.py 10 random`
    - Generates files `data10.txt` containing input for the `Profiler`and `data10_ref` containing input for online calculators of the standard deviaton such as [this one](https://www.hackmath.net/cz/kalkulacka/vypocet-smerodatne-odchylky).
    - File contains random numbers in range `<0; 10>`

- `python3 generate.py 0`
    - Generates empty `data0.txt` and `data0_ref` files.

- - -

# Profiler
Calculates standard deviation for numeric data, passed through `stdin`.
### Usage:
`Profiler.exe`
or
`Profiler.exe < data.txt`

### Compilation:
You can compile `Profiler` following these steps:
1. Open your Windows PowerShell or cmd
2. Set your current path to `ivs-proj-2/src/profiler/`
3. Type in `dotnet build`

- After the project is compiled, you should see green text saying: `Vytváření sestavení bylo úspěšně dokončeno.`
- The executable `Profiler.exe` will be located in `ivs-proj-2/src/profiler/bin/Debug/net6.0-windows/`

### Output:
- Calculated standard deviation, written on `stdout`
- If the program finds out, there is only less than 2 numeric data to work with, `0` will be written on `stdout`
