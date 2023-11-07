

export default function Status({ squares, xIsNext, calculateWinner }) {
    const winner = calculateWinner(squares);
    let status;

    if (winner) {
        status = "Winner: " + winner;
    } else {
        if (!squares.some(element => element === null)) {
            status = "It is a tie."
        } else {
            status = "Next player: " + (xIsNext ? "X" : "O");
        }
    }
    console.log({ status });
    return <div className="status">{status}</div>
}

