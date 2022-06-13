<div align = left>
  <h1>Darkest_Lives_LifeCycle</h1>
  
  <p>광석의 발광을 담당하는 AreaLight들을 배열로 담아 Revoke 함수를 통해 특정 시간마다  조명들의 값을 조절하여 밤낮 시스템 구현</p>
  
  <h2>1.낮 시스템 구현 (Rising_Light())</h2>
  <div>
    <a href="https://github.com/seokho94/PORTFOLIO/blob/main/C%23/Darkest_Lives_Project/LifeCycle/gif/turnOn.gif"><img src = "https://github.com/seokho94/PORTFOLIO/blob/main/C%23/Darkest_Lives_Project/LifeCycle/gif/turnOn.gif" alt="turnOn.gif"></a>
  </div>
  
  <p>Revoke 함수를 사용하여 일정 주기로 빛의 세기 조절  Rising_Light 메소드를 활용하여 주기마다 (빛의 최대 세기 / 반복 시간) 값으로 빛의 세기 증가</p>  <p>https://github.com/seokho94/PORTFOLIO/blob/main/C%23/Darkest_Lives_Project/LifeCycle/gif/turnOn.gif</p>
  <h2>2.밤 시스템 구현 (SinkingLight())</h2>
  <div>
    <a href="https://github.com/seokho94/PORTFOLIO/blob/main/C%23/Darkest_Lives_Project/LifeCycle/gif/turnOff.gif"><img src = "https://github.com/seokho94/PORTFOLIO/blob/main/C%23/Darkest_Lives_Project/LifeCycle/gif/turnOff.gif" alt="turnOff.gif"></a>
  </div>
  
  <p>Revoke 함수를 사용하여 일정 주기로 빛의 세기 조절  Sinking_Light 메소드를 활용하여 주기마다 (빛의 최대 세기 / 반복 시간) 값으로 빛의 세기 감소</p>  <p>https://github.com/seokho94/PORTFOLIO/blob/main/C%23/Darkest_Lives_Project/LifeCycle/gif/turnOff.gif</p>  
  
  <p>빛의 세기가 최댓값 및 최솟값이 되었을 때, bool 값인 isLite의 값을 변경하여 밤낮 전환 시점 파악</p>
  
  <h2>Code</h2>
    https://github.com/seokho94/PORTFOLIO/blob/main/Darkest_Lives_Project/LifeCycle/code/Light_Cycle.cs
    
</div>
