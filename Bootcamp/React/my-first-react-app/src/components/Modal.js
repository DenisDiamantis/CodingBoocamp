import ReactDOM from 'react-dom';
import './Modal.css';

export default function Modal({ children, handleClose, isSalesModal }) {
    return ReactDOM.createPortal(
        (
            <div className="modal-backdrop">
                <div className="modal"
                    style={{
                        border: "10px solid",
                        borderColor: isSalesModal ? "#ff4500" : "#555",
                        textAlign: "center"
                    }}>
                    {children}
                    <br /><br />
                    <button onClick={handleClose}>Close</button>
                </div>
            </div>
        ), document.body
    )
}