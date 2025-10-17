import '../index.css';

export default function Navbar() {
    return (
        <nav className="navbar">
        <div className="navbar-logo">Helseportalen</div>
        <ul className="navbar-links">
            <li><a href="#home">Hjem</a></li>
            <li><a href="#services">Tjenester</a></li>
            <li><a href="#contact">Kontakt</a></li>
        </ul>
        </nav>
    );
    }