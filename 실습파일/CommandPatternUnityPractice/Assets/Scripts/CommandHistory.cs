using System.Collections.Generic;
using UnityEngine;

public sealed class CommandHistory : MonoBehaviour
{
    private readonly List<IUndoableCommand> commands = new();
    private int currentIndex = -1;

    public int Count => commands.Count;
    public int CurrentIndex => currentIndex;
    public bool CanUndo => currentIndex >= 0;
    public bool CanRedo => currentIndex + 1 < commands.Count;

    public void Execute(IUndoableCommand command)
    {
        if (command == null)
        {
            return;
        }

        // TODO 4: Undo 후 남아 있는 Redo 후보를 삭제하세요.
        // 힌트: currentIndex + 1부터 commands.Count - currentIndex - 1개를 지웁니다.

        // TODO 5: command를 commands에 추가하고 currentIndex를 증가시키세요.

        // TODO 6: command.Execute()를 호출하세요.
    }

    public void Undo()
    {
        // TODO 7: 되돌릴 명령이 없으면 return 하세요.

        // TODO 8: 현재 명령의 Undo()를 호출하고 currentIndex를 1 줄이세요.
    }

    public void Redo()
    {
        // TODO 9: 다시 실행할 명령이 없으면 return 하세요.

        // TODO 10: currentIndex를 1 늘리고 해당 명령의 Execute()를 호출하세요.
    }

    public void Clear()
    {
        commands.Clear();
        currentIndex = -1;
    }
}
