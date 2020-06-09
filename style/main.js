var xhr = new XMLHttpRequest();

var file_path = "score.json";
var score;
var win_count;
var lose_count;
var draw_count;
var sr_img;
var sr_score;
var interval_id;
var block_rev;

function Init() {
  win_count = document.querySelector(".win");
  lose_count = document.querySelector(".lose");
  draw_count = document.querySelector(".draw");
  sr_img = document.querySelector(".sr-logo");
  sr_score = document.querySelector(".sr-score");
  block_rev = document.querySelector(".block-reveal");
  // xhr.overrideMimeType('application/json');
  ReadScore();
  interval_id = setInterval(ReadScore, 1000);
}

async function sleep(ms) {
  return new Promise((resolve) => setTimeout(resolve, ms));
}

async function ReadScore() {
  console.log("ReadScore");
  // const scores = await fetch(file_path).then(resp => resp.json());
  // SetScore(scores);
  // console.log(scores);
  // xhr.open(
  //   "GET",
  //   "http://localhost:8000/" + file_path + "?dummy=" + Date.now(),
  //   true
  // );
  xhr.open("GET", file_path, true);
  xhr.send();
  xhr.onreadystatechange = function () {
    if (xhr.readyState === 4) {
      score = JSON.parse(xhr.responseText);
      console.log(score);
      SetScore(score);
    }
  };
}

async function SetScore(score) {
  let w_str = "W: " + score.win;
  let l_str = "L: " + score.lose;
  let d_str = "D: " + score.draw;
  let sr_str = score.sr;
  if (
    win_count.innerHTML == w_str &&
    lose_count.innerHTML == l_str &&
    draw_count.innerHTML == d_str &&
    sr_score.innerHTML == sr_str
  ) {
    return;
  }
  block_rev.classList.add("hide");
  console.log("Sleeeeep");
  await sleep(1000);
  win_count.innerHTML = w_str;
  lose_count.innerHTML = l_str;
  draw_count.innerHTML = d_str;
  if (score.sr < 1500) {
    sr_img.src = "./logos/bronze.png";
  } else if (score.sr < 2000) {
    sr_img.src = "./logos/silver.png";
  } else if (score.sr < 2500) {
    sr_img.src = "./logos/gold.png";
  } else if (score.sr < 3000) {
    sr_img.src = "./logos/platinium.png";
  } else if (score.sr < 3500) {
    sr_img.src = "./logos/diamond.png";
  } else if (score.sr < 4000) {
    sr_img.src = "./logos/master.png";
  } else {
    sr_img.src = "./logos/grandmaster.png";
  }
  sr_score.innerHTML = score.sr;
  console.log("Awake");
  block_rev.classList.remove("hide");
}
