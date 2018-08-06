<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use SoftUniBlogBundle\Entity\Article;
use SoftUniBlogBundle\Form\ArticleType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;



class ArticleController extends Controller
{
    /**
     * @Route("/article/create", name="article_create")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */

    function createArticle(Request $request){
        $article = new Article();
        $form = $this->createForm(ArticleType::class, $article);

        $form->handleRequest($request);

        if($form->isSubmitted() && $form->isValid()){
            $article->setAuthor($this->getUser());
            $em = $this->getDoctrine()->getManager();
            $em->persist($article);
            $em->flush();
        }

        return $this->render('article/create.html.twig',
            [
                "form" => $form->createView()
            ]);
    }

    /**
     * @Route("/article/{id}", name="article_view")
     * @param $id
     * @return \Symfony\Component\HttpFoundation\Response
     */

    public function viewArticles($id){
        $article = $this->getDoctrine()->getRepository(Article::class)->find($id);

        return $this->render('article/article.html.twig', ["article" => $article]);
    }

}
