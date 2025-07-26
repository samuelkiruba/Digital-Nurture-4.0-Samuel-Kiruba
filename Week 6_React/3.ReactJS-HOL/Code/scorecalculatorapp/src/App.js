import { CalculateScore } from "./Components/CalculateScore";
function App() {
  return (
    <div>
      <CalculateScore 
        Name="Steeve" 
        school="DNV Public School" 
        total={284} 
        goal={3} 
      />
    </div>
  );
}

export default App;