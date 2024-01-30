$(document).ready(() => {
    init();
    
});

function init() {
    history.scrollRestoration = "manual";
    $('body').css('overflow', 'hidden');
    initButtons();

    // $(window).scroll(scrollAction);
}

function initButtons() {
    $('.main-img').click(openCard);
    $('.btnDelete').click(deletePost);
}

function openCard() {
    const vh = $(window).height();

    $(this).animate({ top: vh * -1 }, 800, () => {
        // 음악 재생
    });
    $('body').animate({ 'backgroundColor': '#ffffff' }, 800);

    $('body').css('overflow', 'visible');
}

function deletePost() {
    console.log('Delete Post!');
    // 포스트 삭제 확인 팝업
}

function scrollAction() {
    const top = $(this).scrollTop();
    const height = $(this).height();

    if (top <= height) {

    }
}