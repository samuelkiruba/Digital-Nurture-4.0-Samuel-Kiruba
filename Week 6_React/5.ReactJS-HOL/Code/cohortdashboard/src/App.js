import React from 'react';
import CohortDetails from './Components/CohortDetails';

function App() {
  return (
    <div>
      <h1>Cohort Details</h1>
      <CohortDetails
        name="INTADMDF10 - .NET FSD"
        startedon="22-Feb-2022"
        status="Scheduled"
        coach="Aathma"
        trainer="Joja Jose"
      />

      <CohortDetails
        name="ADM21JF014 - Java FSD"
        startedon="10-Sep-2021"
        status="Ongoing"
        coach="Apoorv"
        trainer="Elisa Smith"
      />

      <CohortDetails
        name="CDBJF21025 - Java FSD"
        startedon="24-Dec-2021"
        status="Ongoing"
        coach="Aathma"
        trainer="John Doe"
      />
    </div>
  );
}

export default App;
