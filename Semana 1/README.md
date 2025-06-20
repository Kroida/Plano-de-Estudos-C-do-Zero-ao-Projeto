# Diferença entre Console.Write e Console.WriteLine

Este exemplo demonstra a diferença entre os métodos `Console.WriteLine()` e `Console.Write()` em C#.

---

## Console.WriteLine()

- Imprime uma mensagem no console de saída.
- Adiciona uma quebra de linha ao final, como se tivesse pressionado Enter.

```csharp
Console.WriteLine("Olá, mundo!");
```

## Console.Write()

- Imprime uma mensagem no console de saída.
- Não adiciona uma quebra de linha ao final.

```csharp
Console.Write("Olá, ");
Console.Write("mundo!");
```

Como você pode ver neste exemplo, `Console.Write()` permite que você continue na mesma linha para a próxima saída.