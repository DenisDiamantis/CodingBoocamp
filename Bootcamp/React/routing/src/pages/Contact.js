import { useNavigate } from "react-router-dom";
export default function Contact() {
    let navigate = useNavigate();
    return (
        <div>
            <h2>Contact</h2>
            <p>Contact Contact Contact Contact Contact Contact</p>
            <button onClick={()=>navigate('/')}>Back Home</button>
        </div>
    );
}