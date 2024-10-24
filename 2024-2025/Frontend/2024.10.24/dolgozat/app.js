
const channels = [
    "https://www.youtube.com/embed/u6PV-yNidbY?si=Ez884eDnyv14ndSW",
    "https://www.youtube.com/embed/U_LlX4t0A9I?si=y2Jm2aF3eWKBiG8m",
    "https://www.youtube.com/embed/ggWZoH9PeIU?si=vgWLz_fNbQLimNKY",
    "https://www.youtube.com/embed/GGp-Tr4bUB0?si=aj_hdQ6GUhxqjZHD",
    "https://www.youtube.com/embed/i2kVcGrYKH4?si=JmP0WrIWPjB7UKbf",
    "https://www.youtube.com/embed/x9BpMEsgnew?si=yxUrk9H2wgztM5uY"
]


let TV_STATE = false;

for (let i = 1; i < 7; i++) {
    document.querySelector('#button-' + i).addEventListener('click', () => {
        switchChannel(i);
    })
}

document.querySelector('#button-on').addEventListener('click', () => {
    TV_STATE = true;
    document.querySelector('#no-channel').classList.remove('hidden');
});

document.querySelector('#button-off').addEventListener('click', () => {
    TV_STATE = false;
    document.querySelector('#tv').src = '';
    document.querySelector('#tv').classList.add('hidden')
});


const switchChannel = (channel) => {

    if (!TV_STATE) {
        alert('Előbb kapcsold be a TV-t!');
        return;
    }

    document.querySelector('#tv').src = channels[channel - 1];
    document.querySelector('#tv').classList.remove('hidden')
    document.querySelector('#no-channel').classList.add('hidden');
};