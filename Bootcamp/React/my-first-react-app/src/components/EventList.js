import React from "react";

export default function EventList({ events, handleClick }) {
    return (
        <div>
            {
                events.map((e, index) => (
                    <React.Fragment key={e.id}>
                        <h2>{index + 1} - {e.title}</h2>
                        <button onClick={() => { handleClick(e.id); }}>Delete Event</button>
                    </React.Fragment>
                ))
            }
        </div>
    )
}