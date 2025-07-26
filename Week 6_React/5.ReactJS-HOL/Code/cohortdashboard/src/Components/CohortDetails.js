import React from 'react';
import styles from '../CohortDetails.module.css';

const CohortDetails = ({ name, startedon, status, coach, trainer }) => {
  const titleStyle = {
    color: status === "Ongoing" ? "green" : "blue"
  };

  return (
    <div className={styles.box}>
      <h3 style={titleStyle}>{name}</h3>
      <dl>
        <dt>Started on:</dt>
        <dd>{startedon}</dd>
        <dt>Current status:</dt>
        <dd>{status}</dd>
        <dt>Coach:</dt>
        <dd>{coach}</dd>
        <dt>Trainer:</dt>
        <dd>{trainer}</dd>
      </dl>
    </div>
  );
};

export default CohortDetails;
