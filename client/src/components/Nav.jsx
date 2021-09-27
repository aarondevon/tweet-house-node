import React from 'react';
import { Link } from 'react-router-dom';

function Nav() {
  return (
    <nav>
      <ul className="nav">
        <li className="nav-item">
          <Link className="nav-link active" to="/">Home</Link>
        </li>
        <li className="nav-item">
          <Link className="nav-link" to="/random-tweet">Random Tweet</Link>
        </li>
        <li className="nav-item">
          <Link className="nav-link" to="tweet-search">Tweet Search</Link>
        </li>
      </ul>
    </nav>
  );
}

export default Nav;
