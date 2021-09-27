/* eslint-disable react/button-has-type */
import React from 'react';

function UserCard(props) {
  return (
    <div className="card">
      <div className="row">
        <div className="col-4 flex center-x center-y">
          <img className="profile-picture" src={props.userData.profileImageUrl} alt="twitter profile" />
        </div>
        <div id="user-content" className="col-8">
          <div className="row">
            <div className="col-12">
              <div className="card-body">
                <h5 className="card-title">
                  {props.userData.name}
                </h5>
                <h6 className="card-subtitle mb-2 text-muted">
                  {`@${props.userData.screenName}`}
                </h6>
                <button className="btn btn-primary" onClick={() => props.getRandomTweet(props.userData.screenName)}>View Tweet</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default UserCard;
